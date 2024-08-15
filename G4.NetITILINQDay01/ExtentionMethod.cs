using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITILINQDay01
{
    //Extention Method
    // Class => Static
    // Function => Static
    // this
    public static class ExtentionMethod
    {
        public static int GetWordsCountEx(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                return str.Split(' ').Length;
            }
            return 0;
        }
    }
}
