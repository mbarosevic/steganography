using MetroSet_UI.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steganography
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _filePath;
        private string _textToEncode;
        private double _textSizeToFit;
        private Image _loadedImage;

        public string OpenImage()
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

        public void SaveImage(Bitmap encodedImage)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.InitialDirectory = "c:\\";
            saveImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            saveImage.FilterIndex = 2;
            saveImage.RestoreDirectory = true;

            string filePath;
            if(saveImage.ShowDialog() == DialogResult.OK)
            {
                filePath = saveImage.FileName.ToString();
                encodedImage.Save(filePath);
                MessageBox.Show("Image successfully saved!", "OK");
            } else
            {
                MessageBox.Show("Saving failed!", "Error");
            }
        }

        private void LoadImage()
        {
            _loadedImage = Image.FromFile(_filePath);
            _textSizeToFit = (8.0 * ((_loadedImage.Height * (_loadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
            pbxImage.ImageLocation = _filePath;
        }

        private void TextBoxEncodeClicked(object sender, EventArgs e)
        {
            tbxTextToEncode.Text = "";
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

        private void EncodeBrowseBtnClick(object sender, EventArgs e)
        {
            lblEncodeFilePath.Text = OpenImage();
        }

        private void DecodeBrowseBtnClick(object sender, EventArgs e)
        {
            lblDecodeFilePath.Text = OpenImage();
        }

        private void EncodeBtnClick(object sender, EventArgs e)
        {
            _textToEncode = tbxTextToEncode.Text;

            if (_textToEncode.Length != 0)
            {
                if (CheckTextLength(_textToEncode) && ImageLoaded())
                {
                    Steganography stg = new Steganography();
                    Bitmap bitmapWOEncodedText = new Bitmap(_filePath);

                    //return value of Encode method should be Bitmap
                    Bitmap bitmapWEncodedText = stg.Encode(bitmapWOEncodedText, _textToEncode);
                    //SaveFileDialog
                    SaveImage(bitmapWEncodedText);
                }
                else
                {
                    MessageBox.Show("Please check the image source or text length!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter the text you want to encode!", "Error");
            }
        }

        private void DecodeBtnClick(object sender, EventArgs e)
        {
            string pathPlaceholder = "No file selected";
            if (lblDecodeFilePath.Text == pathPlaceholder || lblDecodeFilePath.Text == "")
            {
                MessageBox.Show("Please select an image file!", "Error");
            } else
            {
                //Decode
            }
        }
    }
}
