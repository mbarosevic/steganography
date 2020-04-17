﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steganography
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string FilePath { get; set; }
        public double TextSizeToFit { get; set; }
        public  Image LoadedImage { get; set; }

        public string OpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    FilePath = openFileDialog.FileName;
                    LoadImage();
                }
            }
            return FilePath;
        }

        private void LoadImage()
        {
            LoadedImage = Image.FromFile(FilePath);
            TextSizeToFit = (8.0 * ((LoadedImage.Height * (LoadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
            pbxImage.ImageLocation = FilePath;
        }

        private void EncodeBrowseBtnClick(object sender, EventArgs e)
        {
            lblEncodeFilePath.Text = OpenFileDialog();
        }

        private void DecodeBrowseBtnClick(object sender, EventArgs e)
        {
            lblDecodeFilePath.Text = OpenFileDialog();
        }

        private void TextBoxEncodeClicked(object sender, EventArgs e)
        {
            tbxTextToEncode.Text = "";
        }

        private void TextBoxEncodeFocusLeft(object sender, EventArgs e)
        {
            tbxTextToEncode.Text = "Enter your text here...";
        }

        private void TextBoxDecodeClicked(object sender, EventArgs e)
        {
            tbxHiddenMessage.Text = "";
        }

        private void TextBoxDecodeFocusLeft(object sender, EventArgs e)
        {
            tbxHiddenMessage.Text = "Enter your text here...";
        }

        private void EncodeBtnClick(object sender, EventArgs e)
        {
            if (!ImageLoaded())
            {
                MessageBox.Show("Picture not selected!", "Error");
            }
            Steganography stn = new Steganography();
        }

        private void DecodeBtnClick(object sender, EventArgs e)
        {
            if (!ImageLoaded())
            {
                MessageBox.Show("Picture not selected!", "Error");
            }
        }

        public bool ImageLoaded()
        {
            if(FilePath == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool CheckTextLength(string text)
        {
            double textToCheck = (System.Text.Encoding.ASCII.GetByteCount(text)) / 1024;
            if(TextSizeToFit < textToCheck)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
