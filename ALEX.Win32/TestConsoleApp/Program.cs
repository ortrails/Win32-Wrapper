using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using ALEX.Win32;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("GetActiveSchemeGuid : " + PowerManagement.GetActiveSchemeGuid());
        }
    }
}
