using System;
using System.Runtime.InteropServices;

namespace RdpWindowsManager.Controls.Helpers
{
   internal static class Imports
   {
      [DllImport("user32.dll", CharSet = CharSet.Unicode)]
      public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);

      [DllImport("user32")]
      public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
   }
}
