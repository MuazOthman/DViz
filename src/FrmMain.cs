using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DViz.SimpleDot;
using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;

namespace DViz
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // These three instances can be injected via the IGetStartProcessQuery, 
            //                                               IGetProcessStartInfoQuery and 
            //                                               IRegisterLayoutPluginCommand interfaces

            var getStartProcessQuery = new GetStartProcessQuery();
            var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
            var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);

            // GraphGeneration can be injected via the IGraphGeneration interface

            _wrapper = new GraphGeneration(getStartProcessQuery,
                getProcessStartInfoQuery,
                registerLayoutPluginCommand);

            clbNodesToIclude.Height = splitContainer1.Panel1.Height - 5;
            clbNodesToIclude.Width = splitContainer1.Panel1.Width - 130;
        }

        private SimpleDotGraph _graph;

        private readonly GraphGeneration _wrapper;

        private byte[] GetGraphData(string dot)
        {
            return _wrapper.GenerateGraph(dot, Enums.GraphReturnType.Png);
        }

        private void btnLoadFIle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                clbNodesToIclude.ItemCheck -= clbNodesToIclude_ItemCheck;
                var simpleDot = File.ReadAllText(openFileDialog1.FileName);
                _graph = new Parser(ConfigurationManager.AppSettings["rootLabel"] ?? "root").Parse(simpleDot);

                Text = $@"DViz - {openFileDialog1.FileName}";
                clbNodesToIclude.Items.Clear();
                clbNodesToIclude.Items.AddRange(
                    _graph.AllNodes.Keys
                    .Where(k => !k.Equals(_graph.Root.Name))
                    .OrderBy(k => k)
                    .Cast<object>()
                    .ToArray()
                );
                SelectAll();
                EnableDisableButtons();
                RenderGraph();
                clbNodesToIclude.ItemCheck += clbNodesToIclude_ItemCheck;
            }
        }

        private void RenderGraph()
        {
            var dot = NodeToDotConvertor.Convert(_graph.Root);
            var imageData = GetGraphData(dot);
            using (var mem = new MemoryStream())
            {
                mem.Write(imageData, 0, imageData.Length);
                var image = Image.FromStream(mem);
                pic1.Size = image.Size;
                pic1.Image = image;
            }
        }

        private void EnableDisableButtons()
        {
            btnSelectAll.Enabled = clbNodesToIclude.Items.Count > 0;
            btnReverseSelection.Enabled = clbNodesToIclude.Items.Count > 0;
            btnUnselectAll.Enabled = clbNodesToIclude.Items.Count > 0;
        }

        private void SelectAll()
        {
            for (var i = 0; i < clbNodesToIclude.Items.Count; i++)
                clbNodesToIclude.SetItemChecked(i, true);
        }

        private void SelectNone()
        {
            for (var i = 0; i < clbNodesToIclude.Items.Count; i++)
                clbNodesToIclude.SetItemChecked(i, false);
        }

        private void ReverseSelection()
        {
            for (var i = 0; i < clbNodesToIclude.Items.Count; i++)
                clbNodesToIclude.SetItemChecked(i, !clbNodesToIclude.GetItemChecked(i));
        }
        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            SelectNone();
        }

        private void btnReverseSelection_Click(object sender, EventArgs e)
        {
            ReverseSelection();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void RunAnalysis()
        {
            foreach (var node in _graph.AllNodes.Values)
            {
                node.Tag = 0;
            }
            for (var i = 0; i < clbNodesToIclude.Items.Count; i++)
            {
                if (!clbNodesToIclude.GetItemChecked(i))
                {
                    var subtree = _graph.AllNodes[clbNodesToIclude.Items[i].ToString()].GetSubtree();
                    foreach (var node in subtree)
                    {
                        node.Tag = 1;
                    }
                }
            }
            RenderGraph();

        }

        private void clbNodesToIclude_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var clb = (CheckedListBox)sender;
            // Switch off event handler
            clb.ItemCheck -= clbNodesToIclude_ItemCheck;
            clb.SetItemCheckState(e.Index, e.NewValue);
            // Switch on event handler
            clb.ItemCheck += clbNodesToIclude_ItemCheck;

            RunAnalysis();
        }
    }
}
