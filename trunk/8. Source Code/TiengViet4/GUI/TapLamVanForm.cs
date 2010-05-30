using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace TiengViet4
{
    public partial class TapLamVanForm : Form
    {
        private ChonBaiHocForm myParent;

        private string filenoidung;

        private string filedapan;

        private int cauHienTai;

        private DataTable tableLT;

        private DataTable tableGN;

        private int slRecordLT;

        private int slRecordGN;

        private int pictiepstatus;

        private int pictruocstatus;

        public TapLamVanForm(string strMaBaiHoc, ChonBaiHocForm frmParent)
        {
            InitializeComponent();

            cauHienTai = 0;
            pictruocstatus = 0;
            pictiepstatus = 0;
            myParent = frmParent;
            myParent.Hide();
            rtbGhiNho.Visible = false;
            picCauHoi.Visible = false;
            picDapAn.Visible = true;
            try
            {
                tableLT = TapLamVanBUS.LayDanhSachBai(strMaBaiHoc, "TLV_LT");
                tableGN = TapLamVanBUS.LayDanhSachBai(strMaBaiHoc, "TLV_GN");
                slRecordLT = tableLT.Rows.Count;
                slRecordGN = tableGN.Rows.Count;
                layDuongDan();

                if (slRecordLT >= 1)
                    pictiepstatus = 1;

                rtbCauHoi.LoadFile(filenoidung);
                if (pictiepstatus == 1)
                    picCTCauTiepTheo.Visible = true;
                if (pictruocstatus == 1)
                    picCTCauTruoc.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void layDuongDan()
        {
            
                filenoidung = tableLT.Rows[cauHienTai]["FileNoiDung"].ToString();
                filedapan = tableLT.Rows[cauHienTai]["FileDapAn"].ToString();
           
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            cauHienTai++;
            pictruocstatus = 1;
            picCTCauTruoc.Visible = true;
            picCauHoi.Visible = false;
            picDapAn.Visible = true;
            try
            {
                layDuongDan();

                rtbCauHoi.LoadFile(filenoidung);
                rtbBaiLam.Text = "";

                if (cauHienTai == (slRecordLT - 1))
                {
                    picCTCauTiepTheo.Visible = false;
                    pictiepstatus = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            cauHienTai--;
            pictiepstatus = 1;
            picCTCauTiepTheo.Visible = true;
            picCauHoi.Visible = false;
            picDapAn.Visible = true;

            try
            {
                layDuongDan();

                rtbCauHoi.LoadFile(filenoidung);
                rtbBaiLam.Text = "";

                if (cauHienTai == 0)
                {
                    picCTCauTruoc.Visible = false;
                    pictruocstatus = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                rtbCauHoi.LoadFile(filenoidung);
                picDapAn.Visible = true;
                picCauHoi.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNgheVaViet_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            rtbCauHoi.Visible = false;
            rtbBaiLam.Visible = false;
            lblLamBai.Visible = false;
            picCTCauTiepTheo.Visible = false;
            picCTCauTruoc.Visible = false;
            picCauHoi.Visible = false;
            picDapAn.Visible = false;
            rtbGhiNho.Visible = true;            

            try
            {
                if (slRecordGN != 0)
                    rtbGhiNho.LoadFile(tableGN.Rows[0]["FileNoiDung"].ToString());
                else
                    rtbGhiNho.Text = "Bài học này không có ghi nhớ!";
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnChinhTa_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            rtbCauHoi.Visible = true;
            rtbBaiLam.Visible = true;
            lblLamBai.Visible = true;            
            picCauHoi.Visible = false;
            picDapAn.Visible = true;
            rtbGhiNho.Visible = false;

            if (pictiepstatus == 1)
                picCTCauTiepTheo.Visible = true;
            if (pictruocstatus == 1)
                picCTCauTruoc.Visible = true;
        }

        private void picBatDau_Click(object sender, EventArgs e)
        {
            try{
                rtbCauHoi.LoadFile(filedapan);
                picCauHoi.Visible = true;
                picDapAn.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            myParent.Show();
        }

        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            HuongDanSuDungForm frm = new HuongDanSuDungForm();
            frm.Show();
        }
    }
}
