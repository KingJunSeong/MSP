using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MSP.Utils
{
    public class FileHash
    {
        public static string Getmd5FromFiles(string filepath)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filepath);
            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
        }
        public static string Getsha1FromFiles(string filepath)
        {
            using var sha1 = SHA1.Create();
            using var stream = File.OpenRead(filepath);
            return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", string.Empty);
        }
        public static string Getsha256FromFiles(string filepath)
        {
            using var sha256 = SHA256.Create();
            using var stream = File.OpenRead(filepath);
            return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", string.Empty);
        }
    }
}
