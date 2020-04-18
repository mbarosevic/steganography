using System;
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

        private string _filePath;
        private string _textToEncode;
        private double _textSizeToFit;
        private Image _loadedImage;

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
                    _filePath = openFileDialog.FileName;
                    LoadImage();
                }
            }
            return _filePath;
        }

        private void LoadImage()
        {
            _loadedImage = Image.FromFile(_filePath);
            _textSizeToFit = (8.0 * ((_loadedImage.Height * (_loadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
            pbxImage.ImageLocation = _filePath;
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

        private void EncodeBtnClick(object sender, EventArgs e)
        {
            _textToEncode = tbxTextToEncode.Text;

            if(_textToEncode.Length != 0)
            {
                if(CheckTextLength(_textToEncode) && ImageLoaded())
                {
                    /*
                    Steganography stg = new Steganography();
                    stg.Encode();
                    */
                } else
                {
                    MessageBox.Show("Please check the image source or text length!", "Error");
                }
            } else
            {
                MessageBox.Show("Please enter the text you want to encode!", "Error");
            }
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
            if(_filePath == null)
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
            if(_textSizeToFit < textToCheck)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
