using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var simpleDot = File.ReadAllText(openFileDialog1.FileName);
                var _graph = new Parser().Parse(simpleDot);
                var dot = NodeToDotConvertor.Convert(_graph.Root);
                var imageData = GetGraphData(dot);
                using (var mem = new MemoryStream())
                {
                    mem.Write(imageData, 0, imageData.Length);
                    var image = Image.FromStream(mem);
                    pic1.Image = image;
                }
                Text = $"DViz - {openFileDialog1.FileName}";
                clbNodesToIclude.Items.Clear();
                clbNodesToIclude.Items.AddRange(_graph.AllNodes.Keys.Cast<object>().ToArray());
                SelectAll();
                EnableDisableButtons();
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
            for (int i = 0; i < clbNodesToIclude.Items.Count; i++)
                clbNodesToIclude.SetItemChecked(i, true);
        }

        private void SelectNone()
        {
            for (int i = 0; i < clbNodesToIclude.Items.Count; i++)
                clbNodesToIclude.SetItemChecked(i, false);
        }

        private void ReverseSelection()
        {
            for (int i = 0; i < clbNodesToIclude.Items.Count; i++)
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

        private void clbNodesToIclude_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            // Switch off event handler
            clb.ItemCheck -= clbNodesToIclude_ItemCheck;
            clb.SetItemCheckState(e.Index, e.NewValue);
            // Switch on event handler
            clb.ItemCheck += clbNodesToIclude_ItemCheck;
        }

        private void RunAnalysis()
        {
        }
    }
}
