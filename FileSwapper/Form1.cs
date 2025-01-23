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
                folderBrowserDialog.Description = "Selecione um directório para listar os ficheiros";
                folderBrowserDialog.ShowNewFolderButton = false;

                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    var imageInfoList = GetFilesInfo(selectedPath);

                }
            }
        }

        static List<FileDetails> GetFilesInfo(string path)
        {
            var imageExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp"
            };

            var files = Directory.GetFiles(path)
                .Where(file => imageExtensions.Contains(Path.GetExtension(file)));

            var fileDetailsList = new List<FileDetails>();

            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);
                fileDetailsList.Add(new FileDetails
                {
                    FullPath = fileInfo.FullName,
                    FileName = fileInfo.Name,
                    Extension = fileInfo.Extension,
                    Size = fileInfo.Length
                });
            }

            return fileDetailsList;
        }

        class FileDetails
        {
            public string FullPath { get; set; }
            public string FileName { get; set; }
            public string Extension { get; set; }
            public long Size { get; set; }
        }
    }
}
