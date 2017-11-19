namespace DViz
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnLoadFIle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbNodesToIclude = new System.Windows.Forms.CheckedListBox();
            this.btnReverseSelection = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFIle
            // 
            this.btnLoadFIle.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFIle.Name = "btnLoadFIle";
            this.btnLoadFIle.Size = new System.Drawing.Size(150, 28);
            this.btnLoadFIle.TabIndex = 0;
            this.btnLoadFIle.Text = "Open File";
            this.btnLoadFIle.UseVisualStyleBackColor = true;
            this.btnLoadFIle.Click += new System.EventHandler(this.btnLoadFIle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "dependency.sdot";
            this.openFileDialog1.Filter = "Simple Dot files|*.sdot";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbNodesToIclude);
            this.splitContainer1.Panel1.Controls.Add(this.btnReverseSelection);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnselectAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadFIle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 753);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // clbNodesToIclude
            // 
            this.clbNodesToIclude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbNodesToIclude.ColumnWidth = 150;
            this.clbNodesToIclude.FormattingEnabled = true;
            this.clbNodesToIclude.Location = new System.Drawing.Point(166, 9);
            this.clbNodesToIclude.MultiColumn = true;
            this.clbNodesToIclude.Name = "clbNodesToIclude";
            this.clbNodesToIclude.Size = new System.Drawing.Size(1019, 344);
            this.clbNodesToIclude.TabIndex = 1;
            this.clbNodesToIclude.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbNodesToIclude_ItemCheck);
            // 
            // btnReverseSelection
            // 
            this.btnReverseSelection.Enabled = false;
            this.btnReverseSelection.Location = new System.Drawing.Point(12, 114);
            this.btnReverseSelection.Name = "btnReverseSelection";
            this.btnReverseSelection.Size = new System.Drawing.Size(150, 28);
            this.btnReverseSelection.TabIndex = 4;
            this.btnReverseSelection.Text = "Reverse Selection";
            this.btnReverseSelection.UseVisualStyleBackColor = true;
            this.btnReverseSelection.Click += new System.EventHandler(this.btnReverseSelection_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Enabled = false;
            this.btnUnselectAll.Location = new System.Drawing.Point(12, 80);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(150, 28);
            this.btnUnselectAll.TabIndex = 3;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Enabled = false;
            this.btnSelectAll.Location = new System.Drawing.Point(12, 46);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(150, 28);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 370);
            this.panel1.TabIndex = 2;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1193, 369);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 753);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "DViz";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFIle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReverseSelection;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.CheckedListBox clbNodesToIclude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic1;
    }
}

