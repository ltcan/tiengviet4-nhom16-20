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
            this.Close();
            Application.Exit();            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmTapDoc frm2 = new frmTapDoc("123");
            frm2.Show();
            if (tvDanhSachBaiHoc.SelectedIndex == 1)
            {
                frmChinhTa frm = new frmChinhTa("1");
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else if (tvDanhSachBaiHoc.SelectedIndex == 2)
            {
                frmTapDoc frm = new frmTapDoc("123");
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }

    }
}