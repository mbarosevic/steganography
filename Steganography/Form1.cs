using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FilePath { get; set; }

        public string OpenFileDialog()
        {
            var filePath = string.Empty;

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
            Steganography stn = new Steganography();
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
    }
}
