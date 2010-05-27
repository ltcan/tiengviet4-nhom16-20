using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class HuongDanForm : Form
    {
        public HuongDanForm(string strFileHuongDan)
        {
            InitializeComponent();
            btnThoat.Location = new Point(Width - btnThoat.Width - 5, Height - btnThoat.Height - 3);
            axWMPHuongDan.URL = strFileHuongDan;
            axWMPHuongDan.Ctlcontrols.play();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
