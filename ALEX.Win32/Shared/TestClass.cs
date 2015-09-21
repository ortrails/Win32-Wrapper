using System;
using System.Diagnostics;

using ALEX.Win32;

namespace ALEX.Win32
{
    public sealed class TestClass 
    {
        public TestClass()
        {
            Debug.WriteLine("GetActiveSchemeGuid : " + PowerManagement.GetActiveSchemeGuid());
        }
    }
}