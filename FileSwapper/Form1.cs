using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FileSwapper
{
    public partial class Form1 : Form
    {
        public FileInfo CurrentFile;
        public string CurrentPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentPath = folderBrowserDialog.SelectedPath;
                    tbxSearchFolder.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("No folder selected.");
                }
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete(CurrentFile.FullName);
        }

        private void btnKeepFile_Click(object sender, EventArgs e)
        {
            // Skip for next file

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {

        }
    }
}
