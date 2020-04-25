using System;
using System.Drawing;

namespace Steganography
{
    /// <summary>
    /// Steganography class that encode and decode text in selected image 
    /// </summary>
    class Steganography
    {
        public Steganography() { }

        /// <summary>
        /// Encode method that hide the given text in given bitmap image
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="textToEncode"></param>
        /// <param name="passwordSecured">0 if the text is not password secured, othervise it is 1</param>
        /// <returns>bitmap image with hidden text</returns>
        public Bitmap HideText(Bitmap bitmap, string textToEncode, int passwordSecured)
        {
            Console.WriteLine(textToEncode);
            Bitmap nonIndexedBitmap = CreateNonIndexedBitmap(bitmap);
            for (int i = 0; i < nonIndexedBitmap.Width; i++)
            {
                for (int j = 0; j < nonIndexedBitmap.Height; j++)
                {
                    Color pixel = nonIndexedBitmap.GetPixel(i, j);
                    if (i < 1 && j < textToEncode.Length)
                    {
                        /*
                         * Uncomment lines below to check the values of pixels in which every letter is saved
                         * 
                        Console.WriteLine("R= [" + i + "][" + j + "]=" + pixel.R);
                        Console.WriteLine("G= [" + i + "][" + j + "]=" + pixel.G);
                        Console.WriteLine("B= [" + i + "][" + j + "]=" + pixel.B);
                        */
                        char letter = Convert.ToChar(textToEncode.Substring(j, 1));
                        int value = Convert.ToInt32(letter);

                        //Compare the letter with pixel value
                        //Console.WriteLine("letter :" + letter + " value :" + value);
                        
                        nonIndexedBitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if (i == nonIndexedBitmap.Width - 1 && j == nonIndexedBitmap.Height - 1)
                    {
                        //G pixel value is 0 if the text is not password secured
                        //G pixel value is 1 if the text is password secured
                        //B pixel value is the length of the text to hide
                        nonIndexedBitmap.SetPixel(i, j, Color.FromArgb(pixel.R, passwordSecured, textToEncode.Length));
                    }
                }
            }
            return nonIndexedBitmap;
        }

        /// <summary>
        /// Create non indexed bitmap method which returns a non indexed bitmap image
        /// in case of selected indexed image by user
        /// </summary>
        /// <param name="indexedBitmap"></param>
        /// <returns>non indexed image bitmap</returns>
        public Bitmap CreateNonIndexedBitmap(Bitmap indexedBitmap)
        {
            Bitmap nonIndexedBitmap = new Bitmap(indexedBitmap.Width, indexedBitmap.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(nonIndexedBitmap))
            {
                gfx.DrawImage(indexedBitmap, 0, 0);
            }

            return nonIndexedBitmap;
        }

        public bool CheckIfTextIsPasswordSecured(Bitmap bitmap)
        {
            Color gPixel = bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1);

            bool secured = gPixel.G == 1 ? true : false;

            return secured;
        }

        /// <summary>
        /// Decode method that unhide hidden text in given bitmap image
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns>hidden text in bitmap image</returns>
        public string UnhideText(Bitmap bitmap)
        {
            string hiddenMessage = "";
            Color lastPixel = bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1);
            int msgLength = lastPixel.B;
            int encryptedWithPassword = lastPixel.G;
            Console.WriteLine(encryptedWithPassword);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        String letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        //TEST
                        //Console.WriteLine($"letter: {letter}   value {value}");
                        
                        hiddenMessage = hiddenMessage + letter;
                    }
                }
            }
            Console.WriteLine(hiddenMessage);
            return hiddenMessage;
        }
    }
}
