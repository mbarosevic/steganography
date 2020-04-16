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

        public Tuple<string, string> OpenFileDialog()
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return Tuple.Create(filePath, fileContent);
        }

        private void EncodeBrowseBtnClick(object sender, EventArgs e)
        {
            var fileProperties = OpenFileDialog();
            lblEncodeFilePath.Text = fileProperties.Item1;
        }

        private void DecodeBrowseBtnClick(object sender, EventArgs e)
        {
            var fileProperties = OpenFileDialog();
            lblDecodeFilePath.Text = fileProperties.Item1;
            tbxHiddenMessage.Text = fileProperties.Item2;
        }
    }
}
