namespace FileSwapper
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Images");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Videos");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Downloads", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Images");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Test", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.tbxSearchFolder = new System.Windows.Forms.TextBox();
            this.tvwFolders = new System.Windows.Forms.TreeView();
            this.gbxSwap = new System.Windows.Forms.GroupBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnKeepFile = new System.Windows.Forms.Button();
            this.gbxSwap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearchFolder
            // 
            this.tbxSearchFolder.Location = new System.Drawing.Point(13, 13);
            this.tbxSearchFolder.Name = "tbxSearchFolder";
            this.tbxSearchFolder.Size = new System.Drawing.Size(1054, 20);
            this.tbxSearchFolder.TabIndex = 0;
            // 
            // tvwFolders
            // 
            this.tvwFolders.Location = new System.Drawing.Point(13, 51);
            this.tvwFolders.Name = "tvwFolders";
            treeNode1.Name = "Node2";
            treeNode1.Text = "All";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Images";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Videos";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Downloads";
            treeNode5.Name = "Node6";
            treeNode5.Text = "All";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Images";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Test";
            this.tvwFolders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.tvwFolders.Size = new System.Drawing.Size(167, 553);
            this.tvwFolders.TabIndex = 1;
            // 
            // gbxSwap
            // 
            this.gbxSwap.Controls.Add(this.btnKeepFile);
            this.gbxSwap.Controls.Add(this.btnDeleteFile);
            this.gbxSwap.Location = new System.Drawing.Point(187, 51);
            this.gbxSwap.Name = "gbxSwap";
            this.gbxSwap.Size = new System.Drawing.Size(880, 553);
            this.gbxSwap.TabIndex = 2;
            this.gbxSwap.TabStop = false;
            this.gbxSwap.Text = "groupBox1";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(145, 528);
            this.btnDeleteFile.TabIndex = 0;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // btnKeepFile
            // 
            this.btnKeepFile.Location = new System.Drawing.Point(729, 19);
            this.btnKeepFile.Name = "btnKeepFile";
            this.btnKeepFile.Size = new System.Drawing.Size(145, 528);
            this.btnKeepFile.TabIndex = 1;
            this.btnKeepFile.Text = "Keep";
            this.btnKeepFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 616);
            this.Controls.Add(this.gbxSwap);
            this.Controls.Add(this.tvwFolders);
            this.Controls.Add(this.tbxSearchFolder);
            this.Name = "Form1";
            this.Text = "FileSwapper";
            this.gbxSwap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearchFolder;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.GroupBox gbxSwap;
        private System.Windows.Forms.Button btnKeepFile;
        private System.Windows.Forms.Button btnDeleteFile;
    }
}

