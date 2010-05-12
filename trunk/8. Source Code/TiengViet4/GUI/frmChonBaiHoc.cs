using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class frmChonBaiHoc : Form
    {
        public frmChonBaiHoc()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
            Application.Exit();            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tvDanhSachBaiHoc.SelectedIndex == 1)
            {
                frmChinhTa frm = new frmChinhTa("1");
                Hide();
                frm.ShowDialog();
                Close();
            }
            else if (tvDanhSachBaiHoc.SelectedIndex == 2)
            {
                frmTapDoc frm = new frmTapDoc();
                Hide();
                frm.ShowDialog();
                Close();
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

    }
}