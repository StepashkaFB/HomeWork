using System;
using System.Security.Cryptography;

namespace TaksEncrypt
{
    class _Main
    {

        static void Main(string[] args)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            Encryption.PrivateKey = RSA.ToXmlString(true);
            Encryption.PublicKey = RSA.ToXmlString(false);

            Console.WriteLine("Enter your Text: ");
            string MainText = Console.ReadLine();
            Console.WriteLine("RSA -- Text before encryption: " + MainText);

            string EncryptedText = Encryption.Encrypt(MainText);
            Console.WriteLine("RSA -- Encrypted Text: \n" + EncryptedText);

            string DecipheredText = Encryption.Decrypt(EncryptedText);
            Console.WriteLine("RSA -- Decrypted Text: " + DecipheredText);
        }
    }
}
