using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class EncryptionDecryption
    {
        //static void Main()
        //{
        //    string original = "Some data";
        //    using (SymmetricAlgorithm symalgo = new AesManaged())
        //    {
        //        byte[] encrypted = Encrypt(symalgo, original);
        //        string roundtrip = Decrypt(symalgo, encrypted);
        //    }

        //    Console.WriteLine();
        //    Console.ReadLine();
        //}


        //private static byte[] Encrypt(SymmetricAlgorithm symmetricAlgorithm, string original)
        //{
        //    ICryptoTransform encryptor = symmetricAlgorithm.CreateEncryptor(symmetricAlgorithm.Key, symmetricAlgorithm.IV);

        //    using (MemoryStream msEncrypt = new MemoryStream())
        //    {
        //        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //        {
        //            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
        //            {
        //                swEncrypt.Write(original);
        //            }
        //            return msEncrypt.ToArray();
        //        }
        //    }
        //}

        //private static string Decrypt(SymmetricAlgorithm symmetricAlgorithm, byte[] encrypted)
        //{
        //    ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor(symmetricAlgorithm.Key, symmetricAlgorithm.IV);
        //    using (MemoryStream msDecrypt = new MemoryStream(encrypted))
        //    {
        //        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        //        {
        //            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
        //            {
        //                return srDecrypt.ReadToEnd();
        //            }
        //        }
        //    }
        //}
    }
}
