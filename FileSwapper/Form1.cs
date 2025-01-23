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
        public string CurrentFilePath = "";
        public string CurrentPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CurrentPath = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("No folder selected.");
                }
            }
        }

    }
}
