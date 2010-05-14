using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class TapDocForm : Form
    {
        public TapDocForm()
        {
            InitializeComponent();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            btnThanhDieuHuongMatTroi.Visible = false;
            pnlTracNghiem.Expanded = true;
        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }
    }
}