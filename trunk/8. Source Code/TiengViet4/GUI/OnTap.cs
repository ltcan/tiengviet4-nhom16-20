using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class OnTap : Form
    {
        public OnTap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnVeTrangDau_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }
    }
}
