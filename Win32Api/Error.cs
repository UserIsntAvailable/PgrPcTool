﻿using System.Runtime.InteropServices;

namespace Win32Api
{
    public class Error
    {
        #region Ummnaged
        #region Imports
        [DllImport("Kernel32.dll", ExactSpelling = true)]
        public static extern uint GetLastError();
        #endregion
        #endregion
    }
}
