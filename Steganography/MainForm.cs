using MetroSet_UI.Forms;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
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
        private bool _passwordSecured = false;
        private byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

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
            using (SaveFileDialog saveImage = new SaveFileDialog())
            {
                saveImage.InitialDirectory = "c:\\";
                saveImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                saveImage.FilterIndex = 2;
                saveImage.RestoreDirectory = true;

                string filePath;
                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveImage.FileName.ToString();
                    encodedImage.Save(filePath);
                    MessageBox.Show("Image successfully saved!", "OK");
                }
                else
                {
                    MessageBox.Show("Saving failed!", "Error");
                }
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
            if (radioBtnPasswordSecured.Checked)
            {
                if(txtFieldPasswordEncrypt.Text != "" || txtFieldPasswordEncrypt.Text.Length > 3)
                {
                    string password = txtFieldPasswordEncrypt.Text;

                    AesManaged aes = new AesManaged();
                    _textToEncode = aes.Encrypt(_textToEncode, GenerateKey(password), iv);

                    // Hidden text
                    //Console.WriteLine(_textToEncode);
                }
                else
                {
                    MessageBox.Show("Please enter at least 4 characters for password!", "Error");
                }
            } 

            if (_textToEncode.Length != 0)
            {
                if (CheckTextLength(_textToEncode) && ImageLoaded())
                {
                    Steganography stg = new Steganography();
                    using (Bitmap bitmapWOEncodedText = new Bitmap(_filePath))
                    {
                        //return value of Encode method should be Bitmap
                        Console.WriteLine("TEXT LENGTH: " + _textToEncode.Length);
                        Console.WriteLine(_textToEncode);
                        if (_textToEncode.Length > 255)
                        {
                            MessageBox.Show("Text limit is 255 characters!");
                        }
                        else
                        {
                            Console.WriteLine(_textToEncode);
                            Bitmap bitmapWEncodedText = stg.HideText(bitmapWOEncodedText, _textToEncode, Convert.ToInt32(radioBtnPasswordSecured.Checked));
                            //SaveFileDialog
                            SaveImage(bitmapWEncodedText);
                        }
                    }
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
                Steganography stg = new Steganography();
                using (Bitmap bitmapToDecode = new Bitmap(_filePath))
                {
                    //Decode
                    string hiddenText = "";
                    //Check if text is password secured
                    if (stg.CheckIfTextIsPasswordSecured(bitmapToDecode) && txtFieldPasswordDecrypt.Text == "")
                    {
                        MessageBox.Show("Hidden text is password secured. Please provide a password!", "Error");
                    } else if (stg.CheckIfTextIsPasswordSecured(bitmapToDecode) && txtFieldPasswordDecrypt.Text != "")
                    {
                        //DECODE
                        hiddenText = stg.UnhideText(bitmapToDecode);
                        //AES DECODE hiddenText
                    }
                    else
                    {
                        hiddenText = stg.UnhideText(bitmapToDecode);
                    }

                    if (hiddenText == string.Empty && !stg.CheckIfTextIsPasswordSecured(bitmapToDecode))
                    {
                        MessageBox.Show("Selected image does not contain hidden text!", "Error");
                    }
                    else
                    {
                        tbxHiddenMessage.Text = "";
                        if (hiddenText.Length > 200)
                        {
                            tbxHiddenMessage.ScrollBars = ScrollBars.Vertical;
                        }
                        else
                        {
                            tbxHiddenMessage.ScrollBars = ScrollBars.None;
                        }
                        tbxHiddenMessage.Text = hiddenText;
                    }
                }
            }
        }

        private void RadioBtnPasswordSecuredCheckedChanged(object sender, EventArgs e)
        {
            _passwordSecured = radioBtnPasswordSecured.Checked;
            txtFieldPasswordEncrypt.Enabled = true;
            txtFieldPasswordEncrypt.Text = "";
        }

        private void RadioBtnPasswordSecuredClick(object sender, EventArgs e)
        {
            if(radioBtnPasswordSecured.Checked && !_passwordSecured)
            {
                radioBtnPasswordSecured.Checked = false;
                txtFieldPasswordEncrypt.Enabled = false;
                txtFieldPasswordEncrypt.Text = "Password";
            } else
            {
                radioBtnPasswordSecured.Checked = true;
                _passwordSecured = false;
            }
        }

        private byte[] GenerateKey(string password)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
                return key;
            }
        }
    }
}
