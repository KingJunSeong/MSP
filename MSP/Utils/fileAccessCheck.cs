using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP.Utils
{
    class fileAccessCheck
    {
        public static bool IsAccessAble(string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open,
                    FileAccess.ReadWrite,
                    FileShare.None);
            } catch (IOException)
            {
                return false;
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }

            return true;
        }
    }
}
