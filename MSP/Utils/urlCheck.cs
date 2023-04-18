using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSP.Utils
{
    class urlCheck
    {
        public static bool IsUrl(string text)
        {
            return Regex.IsMatch(text, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?");
        }
    }
}
