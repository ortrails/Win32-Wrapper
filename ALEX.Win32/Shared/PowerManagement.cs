using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ALEX.Win32
{
    //public sealed class PowerManagement
    public class PowerManagement
    {
        public static Guid GetActiveSchemeGuid()
        {
            var activeGuidPtr = IntPtr.Zero;

            var result = PowerGetActiveScheme(IntPtr.Zero, ref activeGuidPtr);
            if (result != SystemErrorCodes.ERROR_SUCCESS)
            {
                Debug.Assert(activeGuidPtr == IntPtr.Zero);
                throw new Exception("PowerGetActiveScheme; Error:" + result);
            }

            var activeGuid = Marshal.PtrToStructure<Guid>(activeGuidPtr);
            Marshal.FreeHGlobal(activeGuidPtr);
            return activeGuid;
        }

        enum SystemErrorCodes : UInt32
        {
            ERROR_SUCCESS = 0,
            ERROR_NO_MORE_ITEMS = 259
        }

        [DllImport("powrprof.dll")]
        static extern SystemErrorCodes PowerGetActiveScheme(IntPtr RootPowerKey, ref IntPtr ActivePolicyGuid);
    }
}