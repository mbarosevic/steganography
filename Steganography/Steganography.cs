using System;
using System.Drawing;

namespace Steganography
{
    class Steganography
    {
        public Steganography()
        {

        }

        public Bitmap Encode(Bitmap bitmap, string textToEncode) {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    if (i < 1 && j < textToEncode.Length)
                    {
                        //TEST
                        Console.WriteLine("R= [" + i + "][" + j + "]=" + pixel.R);
                        Console.WriteLine("G= [" + i + "][" + j + "]=" + pixel.G);
                        Console.WriteLine("B= [" + i + "][" + j + "]=" + pixel.B);
                        char letter = Convert.ToChar(textToEncode.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter :" + letter + " value :" + value);
                        bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if (i == bitmap.Width - 1 && j == bitmap.Height - 1)
                    {
                        //bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textToEncode.Length));
                        
                        bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, pixel.B));
                    }
                }
            }
            return bitmap;
        }

        public void Decode()
        {

        }
    }
}
