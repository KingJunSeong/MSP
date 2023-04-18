using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP.Utils
{
    class urlEncoding
    {
        public static string UrlEncode(string url)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(url);
            string encode = Convert.ToBase64String(bytes);
            encode = encode.Replace("+", "-").Replace("/", "_").TrimEnd('=');
            return encode;
        }
    }
}
