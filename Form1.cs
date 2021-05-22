using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Darewro_PDF {
    public partial class Form1 : Form {
        
        public DirectoryInfo inputFolder;
        public List<string> ImagesFilesList;
        public string selectedImage = "0x8";

        public Form1() {
            InitializeComponent();
            InputTextBox.Text = @"C:\";
            OutputTextBox.Text = @"C:\";
            ImagesFilesList = new List<string>();
        }

        private void InputFolderBrowseButton_Click(object sender, EventArgs e) {
            SelectFolderDialog.Description = "Select the folder where your images are saved.";
            if (SelectFolderDialog.ShowDialog() == DialogResult.OK) {
                InputTextBox.Text = SelectFolderDialog.SelectedPath;
                ReloadImageList();
            }
        }

        private void OutputFolderBrowseButton_Click(object sender, EventArgs e) {
            SelectFolderDialog.Description = "Select where you want to save the resulting PDF doc.";
            if (SelectFolderDialog.ShowDialog() == DialogResult.OK) {
                OutputTextBox.Text = SelectFolderDialog.SelectedPath;
            }
        }
        private void ReloadButton_Click(object sender, EventArgs e) {
            ReloadImageList();
        }

        private void ConvertButton_Click(object sender, EventArgs e) {
            if (InputTextBox.Text == @"C:\") {
                MessageBox.Show("Please choose an images folder...",
                    ":(",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            } else {
                WritePdf();
            }
        }

        private void PdfNameTextBox_DoubleClick(object sender, EventArgs e) {
            var thisBox = (TextBox) sender;
            thisBox.SelectAll();
            thisBox.Focus();
        }

        private void InputTextBox_DoubleClick(object sender, EventArgs e) {
            var thisBox = (TextBox) sender;
            thisBox.SelectAll();
            thisBox.Focus();
        }

        private void OutputTextBox_DoubleClick(object sender, EventArgs e) {
            var thisBox = (TextBox) sender;
            thisBox.SelectAll();
            thisBox.Focus();
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ReloadImageList();
            }
        }


        public void WritePdf() {
            Document mainDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            try {
                PdfWriter.GetInstance(mainDoc,
                    new FileStream($@"{OutputTextBox.Text}\{PdfNameTextBox.Text}.pdf", FileMode.Create)
                    );
                mainDoc.Open();
                foreach(var image in ImagesFilesList) {
                    var img = iTextSharp.text.Image.GetInstance(image);
                    img.ScaleToFit(mainDoc.PageSize);
                    img.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    mainDoc.Add(img);
                }
            } catch (Exception e) {
                //TODO: Log any errors
            } finally {
                mainDoc.Close();
                MessageBox.Show($"{PdfNameTextBox.Text}.pdf Generated",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        public void ReloadImageList() {
            ImagesListBox.Items.Clear();
            ImagesFilesList.Clear();
            inputFolder = new DirectoryInfo(InputTextBox.Text);
            foreach (var file in inputFolder.GetFiles("*.jp*")) {
                if (file.Name != selectedImage) { 
                    ImagesFilesList.Add(file.FullName);
                    ImagesListBox.Items.Add($"{file.Name}");
                }
            }
        }

    }
}
