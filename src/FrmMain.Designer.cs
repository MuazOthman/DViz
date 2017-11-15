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
            this.btnLoadFIle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReverseSelection = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.clbNodesToIclude = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(1193, 369);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.btnReverseSelection);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnselectAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.clbNodesToIclude);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadFIle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pic1);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 753);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
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
            // clbNodesToIclude
            // 
            this.clbNodesToIclude.FormattingEnabled = true;
            this.clbNodesToIclude.Location = new System.Drawing.Point(168, 12);
            this.clbNodesToIclude.Name = "clbNodesToIclude";
            this.clbNodesToIclude.Size = new System.Drawing.Size(245, 344);
            this.clbNodesToIclude.TabIndex = 1;
            this.clbNodesToIclude.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbNodesToIclude_ItemCheck);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 753);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "DViz";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFIle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnReverseSelection;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.CheckedListBox clbNodesToIclude;
    }
}

