using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            lblBatDau.Visible = true;
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
            lblBatDau.Visible = true;
        }

        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //this.Hide();
            ChonBaiHocForm frm = new ChonBaiHocForm(this);
            frm.Location = Location;            
            frm.Show();
            this.Cursor = Cursors.Default;
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            KeChuyenForm frm = new KeChuyenForm();
            frm.Show();
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
        }

        private void btnEnter_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap("../../Resources/conecting.png");
             btnEnter.BackgroundImage =bm;
        }

        private void btnHuongDan_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            HuongDanSuDungForm frm = new HuongDanSuDungForm();
            frm.Show();
        }
    }
}