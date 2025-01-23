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
using Microsoft.VisualBasic.FileIO;


namespace FileSwapper
{
    public partial class Form1 : Form
    {
        public string CurrentPath = "";
        public List<FileInfo> Files;
        public int FileIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false;

                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbxSearchFolder.Text = folderBrowserDialog.SelectedPath;

                    Files = GetImagesList(folderBrowserDialog.SelectedPath);

                    GoToNextImage();
                }
            }
        }

        static List<FileInfo> GetImagesList(string path)
        {
            var imageExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp"
            };

            var files = Directory.GetFiles(path)
                .Where(file => imageExtensions.Contains(Path.GetExtension(file)));

            var fileDetailsList = new List<FileInfo>();

            foreach(var file in files)
            {
                fileDetailsList.Add(new FileInfo(file));
            }

            return fileDetailsList;
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
                string imagePath = Files[FileIndex].FullName;
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
                MessageBox.Show("No more images in this folder");
            }

            return false;
        }

        public bool GoToPreviousImage()
        {
            // TODO: if the last image was deleted restore it using Shell32 to access the recycle bin
            if (FileIndex - 1 >= 0)
            {
                FileIndex--;
                lblCountFiles.Text = $"{FileIndex + 1}/{Files.Count}";
                string currentDirectory = Directory.GetCurrentDirectory();
                string htmlFilePath = Path.Combine(currentDirectory, "ShowImage.html");
                string imagePath = Files[FileIndex].FullName;
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
                MessageBox.Show("No more images to go back to in this folder");
            }

            return false;
        }

        public bool BuildImageViewer()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            try
            {
                File.WriteAllText(Path.Combine(currentDirectory, "ShowImage.html"), "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Image Viewer</title> <style> #viewImage { width: 500px; max-height: 400px; } </style> <script> window.onload = function () { var queryString = window.location.search; var path = null; if (queryString) { var params = queryString.substring(1).split(\"&\"); for (var i = 0; i < params.length; i++) { var pair = params[i].split(\"=\"); if (pair[0] === \"path\") { path = decodeURIComponent(pair[1]); break; } } } var viewImage = document.getElementById(\"viewImage\"); if (viewImage && path) { viewImage.src = path; } }; </script></head><body> <center> <img id=\"viewImage\" src=\"\" alt=\"Image will appear here\" /> </center></body></html>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildImageViewer();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileSystem.DeleteFile(Files[FileIndex].FullName,UIOption.OnlyErrorDialogs,RecycleOption.SendToRecycleBin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            GoToNextImage();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoToPreviousImage();
        }

        private void btnKeepFile_DragDrop(object sender, DragEventArgs e)
        {
            GoToNextImage();
        }

        private void btnKeepFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnKeepFile_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnDeleteFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                FileSystem.DeleteFile(Files[FileIndex].FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            GoToNextImage();
        }

        private void btnDeleteFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnDeleteFile_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
