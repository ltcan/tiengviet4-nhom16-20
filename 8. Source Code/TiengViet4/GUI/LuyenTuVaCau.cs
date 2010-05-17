using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class LuyenTuVaCau : Form
    {
        public LuyenTuVaCau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }
    }
}
