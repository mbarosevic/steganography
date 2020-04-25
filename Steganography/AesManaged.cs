using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class AesManaged
    {
        public AesManaged() { }

        public string Encrypt(string plainText, byte[] key, byte[] iv)
        {
            // String symmetric encryption AES
            using (Aes encryptor = Aes.Create())
            {
                encryptor.Mode = CipherMode.CBC;
                byte[] aesKey = new byte[32];
                Array.Copy(key, 0, aesKey, 0, 32);
                encryptor.Key = aesKey;
                encryptor.IV = iv;

                MemoryStream memoryStream = new MemoryStream();
                ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

                // Convert the plainText string into a byte array
                byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

                // Encrypt the input plaintext string
                cryptoStream.Write(plainBytes, 0, plainBytes.Length);

                // Complete the encryption process
                cryptoStream.FlushFinalBlock();

                // Convert the encrypted data from a MemoryStream to a byte array
                byte[] cipherBytes = memoryStream.ToArray();

                memoryStream.Close();
                cryptoStream.Close();

                // Convert the encrypted byte array to a base64 encoded string
                string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

                return cipherText;
            }
        }

    }
}
