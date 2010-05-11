using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class frmTiengViet4 : Form
    {
        public frmTiengViet4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblTiengViet_Click(object sender, EventArgs e)
        {
            if (btnEnter.Visible == true)
            {
                btnEnter.Visible = false;
            }
            pnlGioiThieu.TitleText = "Tiếng Việt";
            pnlGioiThieu.AnimationTime = 100;
            pnlGioiThieu.Expanded = false;
            pnlGioiThieu.Text = "PHẦN TIẾNG VIỆT";
            pnlGioiThieu.AnimationTime = 700;
            pnlGioiThieu.Expanded = true;
            btnEnter.Visible = true;
        }

        private void lblGiaiTri_Click(object sender, EventArgs e)
        {
            if (btnEnter.Visible == true)
                btnEnter.Visible = false;
            pnlGioiThieu.TitleText = "Giải Trí";
            pnlGioiThieu.AnimationTime = 100;
            pnlGioiThieu.Expanded = false;
            pnlGioiThieu.Text = "PHẦN GIẢI TRÍ";
            pnlGioiThieu.AnimationTime = 700;
            pnlGioiThieu.Expanded = true;
            btnEnter.Visible = true;
        }

        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmChonBaiHoc frm = new frmChonBaiHoc();
            frm.Location = Location;
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }
    }
}