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

        public TapLamVanForm(string strMaBaiHoc, ChonBaiHocForm frmParent)
        {
            InitializeComponent();

            cauHienTai = 0;
            myParent = frmParent;
            rtbGhiNho.Visible = false;
            picCauHoi.Visible = false;
            picDapAn.Visible = true;
            
            tableLT = TapLamVanBUS.LayDanhSachBai(strMaBaiHoc,"TLV_LT");
            tableGN = TapLamVanBUS.LayDanhSachBai(strMaBaiHoc, "TLV_GN");
            slRecordLT = tableLT.Rows.Count;
            slRecordGN = tableGN.Rows.Count;
            layDuongDan();

            if (slRecordLT >=1)
                picCTCauTiepTheo.Visible = true;

            rtbCauHoi.LoadFile(filenoidung);
        }

        private void layDuongDan()
        {
            filenoidung = tableLT.Rows[cauHienTai]["FileNoiDung"].ToString();
            filedapan = tableLT.Rows[cauHienTai]["FileDapAn"].ToString();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            cauHienTai++;
            picCTCauTruoc.Visible = true;

            layDuongDan();

            rtbCauHoi.LoadFile(filenoidung);
            rtbBaiLam.Text = "";

            if (cauHienTai == (slRecordLT - 1))
                picCTCauTiepTheo.Visible = false;

        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            cauHienTai--;
            picCTCauTiepTheo.Visible = true;

            layDuongDan();

            rtbCauHoi.LoadFile(filenoidung);
            rtbBaiLam.Text = "";

            if (cauHienTai==0)
                picCTCauTruoc.Visible = false;
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            rtbCauHoi.LoadFile(filenoidung);
            picDapAn.Visible = true;
            picCauHoi.Visible = false;
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

            if (slRecordGN != 0)
                rtbGhiNho.LoadFile(tableGN.Rows[0]["FileNoiDung"].ToString());
            else
                rtbGhiNho.Text = "Bài học này không có ghi nhớ!";
            
        }

        private void btnChinhTa_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            rtbCauHoi.Visible = true;
            rtbBaiLam.Visible = true;
            lblLamBai.Visible = true;
            picCTCauTiepTheo.Visible = true;
            picCTCauTruoc.Visible = true;
            picCauHoi.Visible = true;
            picDapAn.Visible = true;
            rtbGhiNho.Visible = false;
        }

        private void picBatDau_Click(object sender, EventArgs e)
        {
            rtbCauHoi.LoadFile(filedapan);
            picCauHoi.Visible = true;
            picDapAn.Visible = false;
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();


        }
    }
}
