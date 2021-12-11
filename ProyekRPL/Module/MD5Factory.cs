// https://riptutorial.com/csharp/example/9341/md5
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProyekRPL.Module
{
    class MD5Factory
    {
        public static string Generate(string str)
        {
            MD5 md5 = MD5.Create();

            // Get bytes from string and compute to hash
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            // Convert hash byte array to string
            return BitConverter.ToString(hash).Replace("-", string.Empty);
        }
    }
}
