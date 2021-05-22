
namespace Darewro_PDF {
    partial class Form1 {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputFolderBrowseButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputFolderBrowseButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ImagesListBox = new System.Windows.Forms.ListBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.PdfNameTextBox = new System.Windows.Forms.TextBox();
            this.OutputPdfNameTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(70, 50);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(280, 20);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.DoubleClick += new System.EventHandler(this.InputTextBox_DoubleClick);
            this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            // 
            // InputFolderBrowseButton
            // 
            this.InputFolderBrowseButton.Location = new System.Drawing.Point(356, 44);
            this.InputFolderBrowseButton.Name = "InputFolderBrowseButton";
            this.InputFolderBrowseButton.Size = new System.Drawing.Size(59, 30);
            this.InputFolderBrowseButton.TabIndex = 1;
            this.InputFolderBrowseButton.Text = "Browse";
            this.InputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.InputFolderBrowseButton.Click += new System.EventHandler(this.InputFolderBrowseButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(70, 101);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(280, 20);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.DoubleClick += new System.EventHandler(this.OutputTextBox_DoubleClick);
            // 
            // OutputFolderBrowseButton
            // 
            this.OutputFolderBrowseButton.Location = new System.Drawing.Point(356, 95);
            this.OutputFolderBrowseButton.Name = "OutputFolderBrowseButton";
            this.OutputFolderBrowseButton.Size = new System.Drawing.Size(59, 30);
            this.OutputFolderBrowseButton.TabIndex = 3;
            this.OutputFolderBrowseButton.Text = "Browse";
            this.OutputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.OutputFolderBrowseButton.Click += new System.EventHandler(this.OutputFolderBrowseButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(234, 230);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(114, 58);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the folder with the images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select where you want to save the pdf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Images Found:";
            // 
            // SelectFolderDialog
            // 
            this.SelectFolderDialog.Description = "Pick the folder with the images.";
            this.SelectFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ImagesListBox
            // 
            this.ImagesListBox.Location = new System.Drawing.Point(120, 209);
            this.ImagesListBox.Name = "ImagesListBox";
            this.ImagesListBox.Size = new System.Drawing.Size(108, 160);
            this.ImagesListBox.TabIndex = 9;
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(234, 294);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(113, 58);
            this.ReloadButton.TabIndex = 10;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // PdfNameTextBox
            // 
            this.PdfNameTextBox.Location = new System.Drawing.Point(239, 150);
            this.PdfNameTextBox.Name = "PdfNameTextBox";
            this.PdfNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.PdfNameTextBox.TabIndex = 11;
            this.PdfNameTextBox.Text = "Result";
            this.PdfNameTextBox.DoubleClick += new System.EventHandler(this.PdfNameTextBox_DoubleClick);
            // 
            // OutputPdfNameTextBox
            // 
            this.OutputPdfNameTextBox.AutoSize = true;
            this.OutputPdfNameTextBox.Location = new System.Drawing.Point(89, 153);
            this.OutputPdfNameTextBox.Name = "OutputPdfNameTextBox";
            this.OutputPdfNameTextBox.Size = new System.Drawing.Size(144, 13);
            this.OutputPdfNameTextBox.TabIndex = 12;
            this.OutputPdfNameTextBox.Text = "Optional Name of the pdf file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 389);
            this.Controls.Add(this.OutputPdfNameTextBox);
            this.Controls.Add(this.PdfNameTextBox);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.ImagesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputFolderBrowseButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputFolderBrowseButton);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Darewro PDF By Tehseen Sajjad";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button InputFolderBrowseButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button OutputFolderBrowseButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog SelectFolderDialog;
        private System.Windows.Forms.ListBox ImagesListBox;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.TextBox PdfNameTextBox;
        private System.Windows.Forms.Label OutputPdfNameTextBox;
    }
}

