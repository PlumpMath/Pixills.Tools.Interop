using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Pixills.Tools.Interop.Windows.Types;

namespace Pixills.Tools.Interop.Windows
{
    internal class Functions
    {
        internal delegate void WindowEventHandler(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
        internal static event WindowEventHandler WindowEvent;

        [DllImport("USER32.DLL", SetLastError = true)]
        internal static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WindowEventHandler lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        [DllImport("USER32.DLL", SetLastError = true)]
        internal static extern int UnhookWinEvent(IntPtr hWinEventHook);

        [DllImport("USER32.DLL", SetLastError = true)]
        internal static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("USER32.DLL", SetLastError = true)]
        internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("USER32.DLL", SetLastError = true)]
        internal static extern bool GetWindowInfo(IntPtr hWnd, out WINDOWINFO info);

        [DllImport(@"C:\Users\Robi\Documents\Visual Studio 2010\Projects\Pixills\Pixills.Tools.Interop\Debug\pnative.dll", SetLastError = true)]
        internal static extern bool DoWork(IntPtr hWnd, String text, String caption);

        private static void OnWindowEvent(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {

        }
    }
}
