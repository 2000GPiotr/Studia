using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Zadanie2._3._3
{
    class Program
    {
        public class CExample
        {

            public static void Main(string[] args)
            {
                using (FileStream fileStream = new FileStream("MyFile.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {
                            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                        };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine("Hello World!");
                            }
                        }
                    }
                }
            }
        }
    }
}
