using System.Windows.Forms;
namespace MergeFiles {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.btnMerge = new System.Windows.Forms.Button();
            this.edtPaths = new System.Windows.Forms.TextBox();
            this.edtOutputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtInputPath = new System.Windows.Forms.TextBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.edtFilesToProcess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerge.Location = new System.Drawing.Point(384, 256);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(80, 23);
            this.btnMerge.TabIndex = 0;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // edtPaths
            // 
            this.edtPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtPaths.Location = new System.Drawing.Point(8, 64);
            this.edtPaths.Multiline = true;
            this.edtPaths.Name = "edtPaths";
            this.edtPaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtPaths.Size = new System.Drawing.Size(456, 142);
            this.edtPaths.TabIndex = 1;
            // 
            // edtOutputs
            // 
            this.edtOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtOutputs.Location = new System.Drawing.Point(8, 225);
            this.edtOutputs.Name = "edtOutputs";
            this.edtOutputs.Size = new System.Drawing.Size(456, 20);
            this.edtOutputs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files to merge";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GetFileList";
            // 
            // edtInputPath
            // 
            this.edtInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInputPath.Location = new System.Drawing.Point(8, 25);
            this.edtInputPath.Name = "edtInputPath";
            this.edtInputPath.Size = new System.Drawing.Size(368, 20);
            this.edtInputPath.TabIndex = 6;
            // 
            // btnGetList
            // 
            this.btnGetList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetList.Location = new System.Drawing.Point(384, 24);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(80, 23);
            this.btnGetList.TabIndex = 7;
            this.btnGetList.Text = "Get List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // edtFilesToProcess
            // 
            this.edtFilesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtFilesToProcess.Location = new System.Drawing.Point(8, 64);
            this.edtFilesToProcess.Multiline = true;
            this.edtFilesToProcess.Name = "edtFilesToProcess";
            this.edtFilesToProcess.ReadOnly = true;
            this.edtFilesToProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtFilesToProcess.Size = new System.Drawing.Size(456, 142);
            this.edtFilesToProcess.TabIndex = 8;
            this.edtFilesToProcess.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 286);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.edtInputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtOutputs);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.edtFilesToProcess);
            this.Controls.Add(this.edtPaths);
            this.Name = "frmMain";
            this.Text = "Folder Merge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMerge;

        private TextBox edtPaths;

        private TextBox edtOutputs;

        private Label label1;

        private Label label2;

        private Label label3;

        private TextBox edtInputPath;

        private Button btnGetList;

        private TextBox edtFilesToProcess;

    }
}

