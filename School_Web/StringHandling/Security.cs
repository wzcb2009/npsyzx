using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
namespace StringHandling
{
    public class Security
    {
        [DebuggerNonUserCode]
        public Security()
        {
        }
        public static string Md5(string passWord)
        {
            byte[] bytes = new UnicodeEncoding().GetBytes(passWord);
            byte[] value = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(bytes);
            return BitConverter.ToString(value);
        }
        public static string Md5_2(string strSource)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            return BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(strSource)));
        }
        public static string Md53(string text)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] array = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(text));
            return BitConverter.ToString(mD5CryptoServiceProvider.Hash);
        }
        public static string Sha1(string passWord)
        {
            byte[] bytes = new UnicodeEncoding().GetBytes(passWord);
            byte[] value = ((HashAlgorithm)CryptoConfig.CreateFromName("SHA1")).ComputeHash(bytes);
            return BitConverter.ToString(value);
        }
    }
}
