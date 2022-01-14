﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLibrary
{
    public class HashWorker
    {
        private const string EncryptionKey = "rdex123";

        public static string Encrypt(string textToEncrypt)
        {
            byte[] textBytes = Encoding.Unicode.GetBytes(textToEncrypt);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x65, 0x65, 0x76 });
                encryptor.Key = rfc.GetBytes(32);
                encryptor.IV = rfc.GetBytes(16);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(textBytes, 0, textBytes.Length);
                        cs.Close();
                    }

                    textToEncrypt = Convert.ToBase64String(ms.ToArray());
                }
            }
            return textToEncrypt;

        }

        public static string Decrypt(string encryptedText)
        {
            encryptedText = encryptedText.Replace(" ", "+");
            byte[] encryptBytes = Convert.FromBase64String(encryptedText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x65, 0x65, 0x76 });
                encryptor.Key = rfc.GetBytes(32);
                encryptor.IV = rfc.GetBytes(16);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptBytes, 0, encryptBytes.Length);
                        cs.Close();
                    }
                    encryptedText = Encoding.Unicode.GetString(ms.ToArray());
                }

            }
            return encryptedText;
        }
    }
}