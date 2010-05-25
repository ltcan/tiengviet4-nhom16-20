using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;

namespace TiengViet4
{
    public partial class LuyenTuVaCauForm : Form
    {
        List<FileLuyenTapDTO> DanhSachDeBai;
        int iDeBaiHienTai;
        string strDapAn;
        
        ChonBaiHocForm frmParent;

        public LuyenTuVaCauForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            InitializeComponent();

            try
            {
                DanhSachDeBai = FileLuyenTapBUS.LayFileTheoMaBaiHoc(strMaBaiHoc);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            iDeBaiHienTai = 0;
            frmParent = MyParent;
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }

        private void LuyenTuVaCau_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;

            if (DanhSachDeBai.Count > 0)
            {
                switch (DanhSachDeBai[0].LoaiFileLuyenTap)
                {
                    case "LTVC_PLT":
                        rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.PhanLoaiTu;
                        break;
                    case "LTVC_TN":
                        rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.TracNghiem;
                        break;

                }

                HienThiBaiHoc();
            }

            frmParent.Hide();
        }

        private void HienThiBaiHoc()
        {
            if (iDeBaiHienTai >= 0 && iDeBaiHienTai < DanhSachDeBai.Count)
            {
                rtfCuaSoHienThi.DocDe(DanhSachDeBai[0].FileNoiDung);
            }
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            if (DanhSachDeBai.Count > 0)
            {
                strDapAn = QuanLyFile.LayNoiDung(DanhSachDeBai[iDeBaiHienTai].FileDapAn);
                rtfCuaSoHienThi.TinhTrangLamBai = TinhTrang.XemDapAn;
                rtfCuaSoHienThi.XemKetQua(strDapAn);
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }
    }
}
