using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace TiengViet4
{
    
    public class TransparentRichTextBox : RichTextBox
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams prams = base.CreateParams;
                if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
                {
                    prams.ExStyle |= 0x020;
                    prams.ClassName = "RICHEDIT50W";
                }
                return prams;
            }
        }
    }  
}
