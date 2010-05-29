using System;
using System.Collections.Generic;
using System.Text;

namespace TiengViet4
{
    public class KhungHuongDan : TransparentRichTextBox
    {
        public KhungHuongDan()
            : base()
        {
            ReadOnly = true;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            Font = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold);
            ForeColor = System.Drawing.Color.Blue;
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
            Caret.HideCaret(Handle);
        }
    }
}
