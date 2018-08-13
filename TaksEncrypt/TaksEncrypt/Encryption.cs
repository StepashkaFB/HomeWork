using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TaksEncrypt
{
    class Encryption
    {
        public static string PrivateKey { get; set; }
        public static string PublicKey { get; set; }
        public static UnicodeEncoding Encoder = new UnicodeEncoding();

        public static string Encrypt(string Data)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(PublicKey);

            byte[] DataToEncrypt = Encoder.GetBytes(Data);
            byte[] EncryptedByteArray = RSA.Encrypt(DataToEncrypt, false).ToArray();

            int length = EncryptedByteArray.Count();
            int item = 0;
            StringBuilder stringbild = new StringBuilder();

            foreach (Byte temp in EncryptedByteArray)
            {
                item++;
                stringbild.Append(temp);
                if (item < length)
                {
                    stringbild.Append("|");
                }   
            }
            return stringbild.ToString();
        }
        public static string Decrypt(string Data)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string[] DataArray = Data.Split(new char[] { '|' });
            byte[] DataByte = new byte[DataArray.Length];

            //Convert to Byte
            for (int Counter = 0; Counter < DataArray.Length; Counter++)
            {
                DataByte[Counter] = Convert.ToByte(DataArray[Counter]);
            }

            RSA.FromXmlString(PrivateKey);
            byte[] decryptedByte = RSA.Decrypt(DataByte, false);
            return Encoder.GetString(decryptedByte);
        }
    }
}
