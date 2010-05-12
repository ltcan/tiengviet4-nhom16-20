using System;
using System.Drawing; 
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace TiengViet4
{
    public enum TinhTrangCaret
    {
        Show,
        Hide
    }
    public class Caret
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool CreateCaret(IntPtr hwnd, IntPtr hbmp, int width, int height);
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool ShowCaret(IntPtr hwnd);
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);
        
        public static void ChangeCaret(IntPtr hwnd, Bitmap bmpCaret)
        {
            CreateCaret(hwnd, bmpCaret.GetHbitmap(), bmpCaret.Width, bmpCaret.Height);
            ShowCaret(hwnd);
        }
    }
}
