using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace TiengViet4
{
    public partial class frmChinhTa : Form
    {
        enum ChucNang{KhongXacDinh, ChinhTa, NgheVaViet, GiaiCauDo}
        ChucNang ChucNangHienTai;

        //Dành cho phần chính tả:
        private List<FileLuyenTap> DanhSachDeBaiChinhTa;
        private int DeChinhTaHienTai;
        //Kết thúc phần khai báo dành cho phần chính tả.

        public frmChinhTa(string MaBaiHoc)
        {
            //Khởi tạo chung:
            InitializeComponent();
            ChucNangHienTai = ChucNang.KhongXacDinh;
            LoiKhuyen();
            //Kết thúc khởi tạo chung.

            //Khởi tạo phần chức năng chính tả:
            klbChinhTa.Visible = false;
            DanhSachDeBaiChinhTa = ChinhTa.LayDanhSachBaiHoc(MaBaiHoc);
            DeChinhTaHienTai = -1;

            //Test
            klbChinhTa.DocDe("21-2.rtf", "10, 15, 50");
            klbChinhTa.TinhTrangBaiLam = TinhTrang.DangLamBai;
            //Kết thúc phần khởi tạo chức năng chính tả.

            //Phần khởi tạo chức năng đọc và viết.
            //--
            //Kết thúc phần khởi tạo chức năng đọc và viết.

            //Phần khởi tạo chức năng giải câu đố.
            //--
            //Kết thúc phần khởi tạo chức năng giải câu đố.            
        }

        private void btnChinhTa_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ChucNangHienTai = ChucNang.ChinhTa;
            klbChinhTa.Visible = false;
            picCTCauTiepTheo.Visible = false;
            picCTCauTruoc.Visible = false;
            picCTKetQua.Visible = false;
            pnlNgheVaViet.Expanded = false;
            pnlGiaiCauDo.Expanded = false;
            lblThongBao.Text = "CHÍNH TẢ";
            picBatDau.Visible = true;
            lblThongBao.Visible = true;

        }

        private void btnNgheVaViet_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ChucNangHienTai = ChucNang.NgheVaViet;
            klbChinhTa.Visible = false;
            picCTCauTiepTheo.Visible = false;
            picCTCauTruoc.Visible = false;
            picCTKetQua.Visible = false;
            klbChinhTa.Visible = false;
            pnlGiaiCauDo.Expanded = false;
            lblThongBao.Text = "NGHE VÀ VIẾT";
            picBatDau.Visible = true;
            lblThongBao.Visible = true;
        }

        private void btnGiaCauDo_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ChucNangHienTai = ChucNang.GiaiCauDo;
            klbChinhTa.Visible = false;
            picCTCauTiepTheo.Visible = false;
            picCTCauTruoc.Visible = false;
            picCTKetQua.Visible = false;
            pnlNgheVaViet.Expanded = false;
            klbChinhTa.Visible = false;
            lblThongBao.Text = "GIẢI CÂU ĐỐ";
            picBatDau.Visible = true;
            lblThongBao.Visible = true;
        }

        private void LoiKhuyen()
        {
            if (DateTime.Now.Hour < 4 || DateTime.Now.Hour > 22)
            {
                lblThongBao.Text = "Em nên đi ngủ sẽ tốt hơn!" +
                                    "\r\nGiờ này học không tốt cho sức khỏe!";
            }
            else if (DateTime.Now.Hour < 11)
            {
                lblThongBao.Text = "Chúc em hôm nay \r\n" +
                                    "có một buổi sáng học tập hiệu quả!";
            }
            else if (DateTime.Now.Hour < 13)
            {
                lblThongBao.Text = "Học vào lúc này là không nên!" +
                                    "\r\nEm nên ăn cơm, sau đó ngủ trưa," +
                                    "\r\nem sẽ có kết quả học tập tốt hơn!";
            }
            else if (DateTime.Now.Hour < 18)
            {
                lblThongBao.Text = "Chúc em hôm nay có một buổi chiều" +
                                    "\r\nhọc tập và giải trí thật vui vẻ!";
            }
            else
            {
                lblThongBao.Text = "Hãy bắt đầu thử sức mình đi nhé!";
            }
        }

        private void picBatDau_Click(object sender, EventArgs e)
        {
            picBatDau.Visible = false;
            lblThongBao.Visible = false;
            if (ChucNangHienTai == ChucNang.ChinhTa)
            {
                klbChinhTa.Visible = true;
                picCTCauTiepTheo.Visible = true;
                picCTCauTruoc.Visible = true;
                picCTKetQua.Visible = true;
                pnlGiaiCauDo.Expanded = false;
                pnlGiaiCauDo.Expanded = false;
            }
            else if (ChucNangHienTai == ChucNang.NgheVaViet)
            {
                pnlNgheVaViet.AnimationTime = 1000;
                pnlNgheVaViet.Expanded = true;
                pnlNgheVaViet.AnimationTime = 100;
                klbChinhTa.Visible = false;
                picCTCauTiepTheo.Visible = false;
                picCTCauTruoc.Visible = false;
                picCTKetQua.Visible = false;
            }
            else if (ChucNangHienTai == ChucNang.GiaiCauDo)
            {
                pnlGiaiCauDo.AnimationTime = 1000;
                pnlGiaiCauDo.Expanded = true;
                pnlGiaiCauDo.AnimationTime = 100;
                klbChinhTa.Visible = false;
                picCTCauTiepTheo.Visible = false;
                picCTCauTruoc.Visible = false;
                picCTKetQua.Visible = false;
            }
            else
            {
                pnlGiaiCauDo.Expanded = false;
                pnlNgheVaViet.Expanded = false;
                picCTCauTiepTheo.Visible = false;
                picCTCauTruoc.Visible = false;
                picCTKetQua.Visible = false;
                klbChinhTa.Visible = false;
                LoiKhuyen();
                picBatDau.Visible = false;
                lblThongBao.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
            Application.Exit();  
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        private void HienThiBaiHoc()
        {
            if (DeChinhTaHienTai > -1)
            {
                klbChinhTa.DocDe(DanhSachDeBaiChinhTa[DeChinhTaHienTai].FileNoiDung, "10, 15, 50");
            }
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            if (DeChinhTaHienTai < DanhSachDeBaiChinhTa.Count && DeChinhTaHienTai > -1)
            {
                ++DeChinhTaHienTai;
                HienThiBaiHoc();
            }
            //test
            klbChinhTa.DocDe("21-3.rtf", "10, 15, 50");
        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            if (DeChinhTaHienTai > 0)
            {
                --DeChinhTaHienTai;
                HienThiBaiHoc();
            }
            //test
            klbChinhTa.DocDe("21-2.rtf", "10, 15, 50");
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            List<String> lstKetQua = ChinhTa.LayDapAn("test.txt");
            klbChinhTa.TinhTrangBaiLam = TinhTrang.XemDapAn;
            klbChinhTa.ReadOnly = true;
            if (lstKetQua.Count != klbChinhTa.DanhSachTu.Count)
            {
                MessageBox.Show("Đề bài và kết quả không khớp nhau!");
                return;
            }
            //Cho nay Thu lam, chay tuyen tinh theo klbChinhTa.DanhSachTu dua vao
            //klbChinhTa.Vitri va klbChinhTa.DanhSachTu[i].NoiDung. Dung klbChinhTa.DanhSachTu[i]; khong dung klbChinhTa.elementAt...
            for (int i = 0; i < lstKetQua.Count; ++i)
            {
                Tu tTu = klbChinhTa.DanhSachTu[i];
                if (tTu.TenLoaiTu == "KhoangTrong")
                {
                    //replace "." trong tTu.NoiDung roi so sanh voi lstKetQua[i].
                }
                else if (tTu.TenLoaiTu == "NhomTu")
                {
                    //So sanh ((NhomTu)tTu).LayTuDaChon() voi lstKetQua[i].
                }
                else if (tTu.TenLoaiTu == "TuInNghieng")
                {
                    //So sanh ((TuInNghien)tTu).LayTu() voi lstKetQua[i].
                    //Ham Laytu nay chua xu ly, nen ket qua luon ra la nguoi dung nhap sai.
                }
            }
        }
    }
}