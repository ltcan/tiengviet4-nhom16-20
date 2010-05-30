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
        private bool Flag = true;
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
            Flag = true;
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
            Flag = false;
        }

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //this.Hide();
            if (this.Flag == true)
            {
                ChonBaiHocForm frm = new ChonBaiHocForm(this);
                frm.Location = Location;
                frm.Show();
                this.Cursor = Cursors.Default;
            }
            else
            {
                ChonGiaiTriForm frm = new ChonGiaiTriForm();
                frm.Location = Location;
                frm.Show();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("btnEnter.BackgroundImage")));
        }

        private void btnEnter_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Bitmap bm = new Bitmap("conecting.png");
                btnEnter.BackgroundImage = bm;
            }
            catch (Exception Ex)
            {
                throw new Exception("Không tìm thấy ảnh conecting.png");
            }
        }


        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            HuongDanSuDungForm frm = new HuongDanSuDungForm();
            frm.Show();
        }
    }
}