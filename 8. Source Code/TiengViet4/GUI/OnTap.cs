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
    public partial class OnTap : Form
    {
        int intDeBaiHienTai;
        List<FileLuyenTapDTO> DanhSachDeBai;
        List<FileAmThanhDTO> DanhSachBaiNghe;
        ChonBaiHocForm frmParent;
        public OnTap(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            InitializeComponent();
            DanhSachDeBai = FileLuyenTapBUS.LayFileTheoMaBaiHoc(strMaBaiHoc);
            frmParent = MyParent;
            frmParent.Hide();
            intDeBaiHienTai = 0;
            BaiHocDTO BaiNghe = BaiHocBUS.LayBaiHocTheoMa(strMaBaiHoc);
            DanhSachBaiNghe = FileAmThanhBUS.LayFileAmThanhTheoMa(BaiNghe.FileAmThanh);
        }
        private void HienThiDeBai()
        {
            if (intDeBaiHienTai >= 0 && intDeBaiHienTai < DanhSachDeBai.Count)
            {
                try
                {
                    rtfCuaSoDeBai.Text = "";
                    rtfDapAn.Text = "";
                    this.rtfCuaSoDeBai.LoadFile(DanhSachDeBai[intDeBaiHienTai].FileNoiDung);
                    int intFlag = 0;
                    for (int i = 0; i < DanhSachBaiNghe.Count; i++)
                    {
                        if (DanhSachBaiNghe[i].Phan == intDeBaiHienTai + 1)
                        {
                            axATOnTap.Visible = true;
                            intFlag = 1;
                            axATOnTap.URL = Application.StartupPath + "\\" + DanhSachBaiNghe[i].DuongDanFileAmThanh;
                        }
                    }
                    if (intFlag == 0)
                    {
                        axATOnTap.Visible = false;                        
                    }
                }
                catch (Exception)
                {
                }
                this.pnlDapAn.Expanded = false;
            }
        }

        private void HienThiDapAn()
        {
            this.pnlDapAn.Expanded = true;
            if (intDeBaiHienTai >= 0 && intDeBaiHienTai < DanhSachDeBai.Count)
            {
                try
                {
                    if (DanhSachDeBai[intDeBaiHienTai].FileDapAn != string.Empty)
                    {
                        rtfDapAn.Visible = true;
                        this.rtfDapAn.LoadFile(DanhSachDeBai[intDeBaiHienTai].FileDapAn);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnVeTrangDau_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }

        private void OnTap_Load(object sender, EventArgs e)
        {
            HienThiDeBai();
        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            intDeBaiHienTai -= 1;
            if (intDeBaiHienTai < 0)
            {
                intDeBaiHienTai = 0;
            }
            axATOnTap.Ctlcontrols.stop();
            HienThiDeBai();
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            intDeBaiHienTai += 1;
            if (intDeBaiHienTai >= DanhSachDeBai.Count)
            {
                intDeBaiHienTai = DanhSachDeBai.Count - 1;
            }
            axATOnTap.Ctlcontrols.stop();
            HienThiDeBai();
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            HienThiDapAn();
        }

        private void btnHuongDan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            axATOnTap.Ctlcontrols.pause();
            HuongDanForm frm = new HuongDanForm("OnTap\\HuongDan.avi");
            frm.ShowDialog();
            if (axATOnTap.Ctlcontrols.currentPosition > 0)
            {
                axATOnTap.Ctlcontrols.play();
            }
        }
    }
}
