using System;
using System.Drawing;

namespace Steganography
{
    class Steganography
    {
        public Steganography()
        {

        }

        public Bitmap Encode(Bitmap bitmap, string textToEncode)
        {
            Bitmap nonIndexedBitmap = CreateNonIndexedBitmap(bitmap);
            for (int i = 0; i < nonIndexedBitmap.Width; i++)
            {
                for (int j = 0; j < nonIndexedBitmap.Height; j++)
                {
                    Color pixel = nonIndexedBitmap.GetPixel(i, j);
                    if (i < 1 && j < textToEncode.Length)
                    {
                        //TEST
                        Console.WriteLine("R= [" + i + "][" + j + "]=" + pixel.R);
                        Console.WriteLine("G= [" + i + "][" + j + "]=" + pixel.G);
                        Console.WriteLine("B= [" + i + "][" + j + "]=" + pixel.B);
                        char letter = Convert.ToChar(textToEncode.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter :" + letter + " value :" + value);
                        nonIndexedBitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if (i == nonIndexedBitmap.Width - 1 && j == nonIndexedBitmap.Height - 1)
                    {
                        nonIndexedBitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textToEncode.Length));

                        //bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, pixel.B));
                    }
                }
            }
            return nonIndexedBitmap;
        }

        public Bitmap CreateNonIndexedBitmap(Bitmap indexedBitmap)
        {
            Bitmap nonIndexedBitmap = new Bitmap(indexedBitmap.Width, indexedBitmap.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(nonIndexedBitmap))
            {
                gfx.DrawImage(indexedBitmap, 0, 0);
            }

            return nonIndexedBitmap;
        }

        public string Decode(Bitmap bitmap)
        {
            string hiddenMessage = "";
            Color lastPixel = bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1);
            int msgLength = lastPixel.B;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        String letter = System.Text.Encoding.UTF8.GetString(new byte[] { Convert.ToByte(c) });
                        //TEST
                        Console.WriteLine($"letter: {letter}   value {value}");
                        hiddenMessage = hiddenMessage + letter;
                    }
                }
            }
            return hiddenMessage;
        }
    }
}
