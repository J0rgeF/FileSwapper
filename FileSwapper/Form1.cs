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
        public List<FileDetails> Files;
        public int FileIndex = -1;
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

                    Files = GetFilesInfo(selectedPath);

                    GoToNextImage();
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

        public class FileDetails
        {
            public string FullPath { get; set; }
            public string FileName { get; set; }
            public string Extension { get; set; }
            public long Size { get; set; }
        }

        private void btnKeepFile_Click(object sender, EventArgs e)
        {
            GoToNextImage();

        }

        public bool GoToNextImage()
        {
            if (FileIndex + 1 < Files.Count)
            {
                FileIndex++;
                lblCountFiles.Text = $"{FileIndex + 1}/{Files.Count}";
                string currentDirectory = Directory.GetCurrentDirectory();
                string htmlFilePath = Path.Combine(currentDirectory, "ShowImage.html");
                string imagePath = Files[FileIndex].FullPath;
                UriBuilder uriBuilder = new UriBuilder
                {
                    Scheme = "file",
                    Path = htmlFilePath,
                    Query = $"path={Uri.EscapeDataString(imagePath)}"
                };
                wbwImage.Url = uriBuilder.Uri;
                return true;
            }
            else
            {
                MessageBox.Show("Não existem mais imagens neste directório!");
            }

            return false;
        }

        public bool BuildImageViewer()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            try
            {
                File.WriteAllText(Path.Combine(currentDirectory, "ShowImage.html"), "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Image Viewer</title> <style> #viewImage { max-width: 400px; height: auto; } </style> <script> window.onload = function () { var queryString = window.location.search; var path = null; if (queryString) { var params = queryString.substring(1).split(\"&\"); for (var i = 0; i < params.length; i++) { var pair = params[i].split(\"=\"); if (pair[0] === \"path\") { path = decodeURIComponent(pair[1]); break; } } } var viewImage = document.getElementById(\"viewImage\"); if (viewImage && path) { viewImage.src = path; } }; </script></head><body> <center> <img id=\"viewImage\" src=\"\" alt=\"Image will appear here\" /> </center></body></html>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildImageViewer();
        }
    }
}
