using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OSCS.WinForms.Registration
{
    class tDes
    {
        // define the triple des provider
        private TripleDESCryptoServiceProvider m_des =
                     new TripleDESCryptoServiceProvider();

        // define the string handler
        private UTF8Encoding m_utf8 = new UTF8Encoding();

        // define the local property arrays
        private byte[] m_key = { 9, 34, 81, 50, 23, 45, 132, 65, 1, 49, 33, 72, 38, 60, 42, 89, 71, 61, 57, 61, 23, 19, 11, 67 };
        private byte[] m_key2 = { 34, 77, 45, 23, 43, 73, 11, 43, 2, 64, 32, 67, 34, 12, 56, 5, 3, 64, 75, 11, 54, 99, 12, 52 };
        //private byte[] m_key3 = { 43, 21, 66, 54, 32, 11, 59, 3, 10, 15, 88, 91, 48, 87, 39, 6, 18, 4, 22, 70, 13, 50, 52, 99 };
        private byte[] m_iv = { 8, 22, 222, 30, 46, 75, 90, 84 };
        private byte[] m_iv2 = { 2, 45, 123, 22, 66, 234, 45, 92 };
        //private byte[] m_iv3 = { 123, 45, 78, 90, 38, 90, 22, 111 };
        //RandomNumberGenerator rng = RandomNumberGenerator.Create();
        //byte[] key = new byte[24]; // For a 192-bit key
        //rng.GetBytes(key);

        public tDes()
        {

        }

        public string Encrypt(string text)
        {
            byte[] input = m_utf8.GetBytes(text);
            byte[] output = Transform(input,
                            m_des.CreateEncryptor(m_key, m_iv));
            return Convert.ToBase64String(output);
        }
        public string Encrypt2(string text)
        {
            byte[] input = m_utf8.GetBytes(text);
            byte[] output = Transform(input,
                            m_des.CreateEncryptor(m_key2, m_iv2));
            return Convert.ToBase64String(output);
        }
        //public string Encrypt3(string text)
        //{
        //    byte[] input = m_utf8.GetBytes(text);
        //    byte[] output = Transform(input,
        //                    m_des.CreateEncryptor(m_key3, m_iv3));
        //    return Convert.ToBase64String(output);
        //}

        public string Decrypt(string text)
        {
            byte[] input = Convert.FromBase64String(text);
            byte[] output = Transform(input,
                            m_des.CreateDecryptor(m_key, m_iv));
            return m_utf8.GetString(output);
        }

        public string Decrypt2(string text)
        {
            byte[] input = Convert.FromBase64String(text);
            byte[] output = Transform(input,
                            m_des.CreateDecryptor(m_key2, m_iv2));
            return m_utf8.GetString(output);
        }

        //public string Decrypt3(string text)
        //{
        //    byte[] input = Convert.FromBase64String(text);
        //    byte[] output = Transform(input,
        //                    m_des.CreateDecryptor(m_key3, m_iv3));
        //    return m_utf8.GetString(output);
        //}

        private byte[] Transform(byte[] input,
                           ICryptoTransform CryptoTransform)
        {
            // create the necessary streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memStream,
                         CryptoTransform, CryptoStreamMode.Write);
            // transform the bytes as requested
            cryptStream.Write(input, 0, input.Length);
            cryptStream.FlushFinalBlock();
            // Read the memory stream and
            // convert it back into byte array
            memStream.Position = 0;
            byte[] result = memStream.ToArray();
            // close and release the streams
            memStream.Close();
            cryptStream.Close();
            // hand back the encrypted buffer
            return result;
        }
    }
}
