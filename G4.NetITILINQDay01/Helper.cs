using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4.NetITILINQDay01
{
    public class Helper
    {
        public static int GetWordsCount(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                return str.Split(' ').Length;
            }
            return 0;
        }
    }
}
