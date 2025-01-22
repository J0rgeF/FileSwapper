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
        private List<FileDetails> imageInfoList;
        private int currentImageIndex = 0; 
        public Form1()
        {
            InitializeComponent();
            imageInfoList = new List<FileDetails>();
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

                    this.imageInfoList = imageInfoList;

                    if (imageInfoList.Count > 0)
                    {
                        ShowCurrentImage();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma imagem encontrada no diretório selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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

        private void btnKeepFile_Click(object sender, EventArgs e)
        {
            MoveToNextImage();
        }

        private void MoveToNextImage()
        {
            if(currentImageIndex < imageInfoList.Count - 1)
            {
                currentImageIndex++;
                ShowCurrentImage();
            }
            else
            {
                MessageBox.Show("Todas as imagens foram processadas!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pboxImage.Image = null; // Limpa o PictureBox
            }
        }

        private void ShowCurrentImage()
        {
            if (currentImageIndex >= 0 && currentImageIndex < imageInfoList.Count)
            {
                var currentImage = imageInfoList[currentImageIndex];

                if (File.Exists(currentImage.FullPath)) // Verifica se o ficheiro ainda existe
                {
                    pboxImage.ImageLocation = currentImage.FullPath; // Atualiza a imagem no PictureBox
                }
                else
                {
                    MessageBox.Show("A imagem não existe mais ou não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MoveToNextImage(); // Passa para a próxima imagem se a atual não existir.
                }
            }
            else
            {
                MessageBox.Show("Índice fora do intervalo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if(imageInfoList.Count > 0 && currentImageIndex >= 0 && currentImageIndex < imageInfoList.Count)
            {
                var currentImage = imageInfoList[currentImageIndex];

                try
                {
                    File.Delete(currentImage.FullPath);
                    imageInfoList.RemoveAt(currentImageIndex);
                    MessageBox.Show("Imagem apagada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MoveToNextImage();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MoveToNextImage();
            }
        }
    }
}
