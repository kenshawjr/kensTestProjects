using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KensConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            int returnCode = 0;
            var o = new KensLibDll.MainUtilityObject();
            string s = o.GetLibraryInfo();
            Console.WriteLine(s);
            Console.ReadKey();
            return returnCode;
        }
    }
}
