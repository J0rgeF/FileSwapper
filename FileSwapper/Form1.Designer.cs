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
            this.tbxSearchFolder = new System.Windows.Forms.TextBox();
            this.gbxSwap = new System.Windows.Forms.GroupBox();
            this.tabcFileViewer = new System.Windows.Forms.TabControl();
            this.tabpImages = new System.Windows.Forms.TabPage();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.tabpVideos = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnKeepFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSwap.SuspendLayout();
            this.tabcFileViewer.SuspendLayout();
            this.tabpImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearchFolder
            // 
            this.tbxSearchFolder.Location = new System.Drawing.Point(13, 13);
            this.tbxSearchFolder.Name = "tbxSearchFolder";
            this.tbxSearchFolder.ReadOnly = true;
            this.tbxSearchFolder.Size = new System.Drawing.Size(971, 20);
            this.tbxSearchFolder.TabIndex = 0;
            // 
            // gbxSwap
            // 
            this.gbxSwap.Controls.Add(this.tabcFileViewer);
            this.gbxSwap.Controls.Add(this.btnGoBack);
            this.gbxSwap.Controls.Add(this.btnKeepFile);
            this.gbxSwap.Controls.Add(this.btnDeleteFile);
            this.gbxSwap.Location = new System.Drawing.Point(12, 39);
            this.gbxSwap.Name = "gbxSwap";
            this.gbxSwap.Size = new System.Drawing.Size(1055, 565);
            this.gbxSwap.TabIndex = 2;
            this.gbxSwap.TabStop = false;
            this.gbxSwap.Text = "Swap";
            // 
            // tabcFileViewer
            // 
            this.tabcFileViewer.Controls.Add(this.tabpImages);
            this.tabcFileViewer.Controls.Add(this.tabpVideos);
            this.tabcFileViewer.Controls.Add(this.tabPage1);
            this.tabcFileViewer.Location = new System.Drawing.Point(169, 20);
            this.tabcFileViewer.Name = "tabcFileViewer";
            this.tabcFileViewer.SelectedIndex = 0;
            this.tabcFileViewer.Size = new System.Drawing.Size(729, 498);
            this.tabcFileViewer.TabIndex = 3;
            // 
            // tabpImages
            // 
            this.tabpImages.Controls.Add(this.label1);
            this.tabpImages.Controls.Add(this.pboxImage);
            this.tabpImages.Location = new System.Drawing.Point(4, 22);
            this.tabpImages.Name = "tabpImages";
            this.tabpImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabpImages.Size = new System.Drawing.Size(721, 472);
            this.tabpImages.TabIndex = 0;
            this.tabpImages.Text = "Images";
            this.tabpImages.UseVisualStyleBackColor = true;
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(7, 24);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(708, 442);
            this.pboxImage.TabIndex = 0;
            this.pboxImage.TabStop = false;
            // 
            // tabpVideos
            // 
            this.tabpVideos.Location = new System.Drawing.Point(4, 22);
            this.tabpVideos.Name = "tabpVideos";
            this.tabpVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpVideos.Size = new System.Drawing.Size(721, 472);
            this.tabpVideos.TabIndex = 1;
            this.tabpVideos.Text = "Videos";
            this.tabpVideos.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 472);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(456, 524);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(120, 23);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            // 
            // btnKeepFile
            // 
            this.btnKeepFile.Location = new System.Drawing.Point(904, 19);
            this.btnKeepFile.Name = "btnKeepFile";
            this.btnKeepFile.Size = new System.Drawing.Size(145, 528);
            this.btnKeepFile.TabIndex = 1;
            this.btnKeepFile.Text = "Keep";
            this.btnKeepFile.UseVisualStyleBackColor = true;
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
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(986, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 616);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.gbxSwap);
            this.Controls.Add(this.tbxSearchFolder);
            this.Name = "Form1";
            this.Text = "FileSwapper";
            this.gbxSwap.ResumeLayout(false);
            this.tabcFileViewer.ResumeLayout(false);
            this.tabpImages.ResumeLayout(false);
            this.tabpImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearchFolder;
        private System.Windows.Forms.GroupBox gbxSwap;
        private System.Windows.Forms.Button btnKeepFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TabControl tabcFileViewer;
        private System.Windows.Forms.TabPage tabpImages;
        private System.Windows.Forms.TabPage tabpVideos;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
    }
}

