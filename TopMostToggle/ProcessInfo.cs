using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MyApp
{
    public class ProcessInfo
    {

        private Process process;

        public ProcessInfo(Process process)
        {
            this.process = process;
        }

        public string Name => process.ProcessName;
        public int ProcessId => process.Id;
        public bool TopMost
        {
            get
            {
                int style = NativeMethods.GetWindowLong(Handle, NativeConstants.GWL_EXSTYLE);
                return (style & NativeConstants.WS_EX_TOPMOST) == NativeConstants.WS_EX_TOPMOST;
            }
            set
            {
                int hWndInsertAfter = (value ? NativeConstants.HWND_TOPMOST : NativeConstants.HWND_NOTOPMOST);
                NativeMethods.SetWindowPos(Handle, hWndInsertAfter, 0, 0, 0, 0, NativeConstants.TOPMOST_FLAGS);
            }
        }
        public string Title => process.MainWindowTitle;
        public WindowState WindowState
        {
            get
            {
                int style = NativeMethods.GetWindowLong(Handle, NativeConstants.GWL_STYLE);

                if ((style & NativeConstants.WS_MAXIMIZE) == NativeConstants.WS_MAXIMIZE)
                {
                    return WindowState.Maximized;
                }
                else if ((style & NativeConstants.WS_MINIMIZE) == NativeConstants.WS_MINIMIZE)
                {
                    return WindowState.Minimized;
                }
                else
                    return WindowState.Normal;
            }
            set
            {
                NativeMethods.ShowWindow(Handle, (int)value);
            }
        }
        public IntPtr Handle => process.MainWindowHandle;

        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, uint flags);

            [DllImport("user32.dll")]
            public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        }
    }
}
