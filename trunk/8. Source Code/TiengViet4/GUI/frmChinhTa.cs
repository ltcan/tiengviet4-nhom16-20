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
        private string strBaiVan;
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
            klbChinhTa.QuanLyDau = new QuanLyDau(@"CaiDat\QuyTacDau.dat");
            DanhSachDeBaiChinhTa = ChinhTa.LayDanhSachBaiHoc(MaBaiHoc);
            DeChinhTaHienTai = -1;

            //Test
            klbChinhTa.DocDe("21-2.rtf", "test.txt", "10, 15, 50");
            strBaiVan = klbChinhTa.Text;
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
                klbChinhTa.DocDe(DanhSachDeBaiChinhTa[DeChinhTaHienTai].FileNoiDung, DanhSachDeBaiChinhTa[DeChinhTaHienTai].FileDapAn, "10, 15, 50");
                strBaiVan = klbChinhTa.Text;
            }
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            Invalidate();
            if (DeChinhTaHienTai < DanhSachDeBaiChinhTa.Count && DeChinhTaHienTai > -1)
            {
                ++DeChinhTaHienTai;
                HienThiBaiHoc();
            }
            //test
            klbChinhTa.DocDe("21-3.rtf", "test1.txt", "10, 15, 50");
            strBaiVan = klbChinhTa.Text;
        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            Invalidate();
            if (DeChinhTaHienTai > 0)
            {
                --DeChinhTaHienTai;
                HienThiBaiHoc();
            }
            //test
            klbChinhTa.DocDe("21-2.rtf", "test.txt", "10, 15, 50");
            strBaiVan = klbChinhTa.Text;
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            klbChinhTa.TinhTrangBaiLam = TinhTrang.XemDapAn;
            klbChinhTa.ReadOnly = true;
            if (klbChinhTa.DapAn.Count != klbChinhTa.DanhSachTu.Count)
            {
                MessageBox.Show("Đề bài và kết quả không khớp nhau!");
                return;
            }

            int Count = 0;
            klbChinhTa.Text = strBaiVan;
            for (int i = 0; i < klbChinhTa.DapAn.Count; ++i)
            {
                Tu tTu = klbChinhTa.DanhSachTu[i];
                if (tTu.TenLoaiTu == "KhoangTrong")
                {
                    string strDapAnNguoiDungNhap = tTu.NoiDung.Replace(".", "");

                    int m1 = tTu.ViTri;
                    int m2 = tTu.NoiDung.Length;
                    int m3 = klbChinhTa.DapAn[i].Length;
                    klbChinhTa.SelectionStart = (m1 + m2 - m3) - (m2 - m3 + 1)/2;
                    klbChinhTa.SelectionLength = m3;

                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2);
                    if (strDapAnNguoiDungNhap.CompareTo(klbChinhTa.DapAn[i]) == 0)
                    {
                        klbChinhTa.SelectionColor = Color.Blue;
                        klbChinhTa.SelectionFont = font;
                        ++Count;
                    }
                    else
                    {
                        klbChinhTa.SelectionColor = Color.Red;
                        klbChinhTa.SelectionFont = font;
                    }
                    klbChinhTa.SelectedText = klbChinhTa.DapAn[i];

                }
                else if (tTu.TenLoaiTu == "NhomTu")
                {
                    int m1 = tTu.ViTri;
                    int m2 = tTu.NoiDung.Length;
                    int m3 = klbChinhTa.DapAn[i].Length;
                    klbChinhTa.SelectionStart = m1 + m2 - m3;
                    klbChinhTa.SelectionLength = m3;
                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2, FontStyle.Underline);
                    if (((NhomTu)tTu).LayTuDaChon().CompareTo(klbChinhTa.DapAn[i]) == 0)
                    {
                        ++Count;
                        klbChinhTa.SelectionColor = Color.Blue;
                        klbChinhTa.SelectionFont = font;
                    }
                    else
                    {
                        klbChinhTa.SelectionColor = Color.Red;
                        klbChinhTa.SelectionFont = font;
                    }
                    klbChinhTa.SelectedText = klbChinhTa.DapAn[i];
                }
                else if (tTu.TenLoaiTu == "TuInNghieng")
                {
                    int m1 = tTu.ViTri;
                    int m2 = tTu.NoiDung.Length;
                    klbChinhTa.SelectionStart = m1;
                    klbChinhTa.SelectionLength = m2;
                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2);
                    if (((TuInNghieng)tTu).NoiDung.CompareTo(klbChinhTa.DapAn[i]) == 0)
                    {
                        ++Count;
                        klbChinhTa.SelectionColor = Color.Blue;
                        klbChinhTa.SelectionFont = font;
                    }
                    else
                    {
                        klbChinhTa.SelectionColor = Color.Red;
                        klbChinhTa.SelectionFont = font;
                    }
                    klbChinhTa.SelectedText = klbChinhTa.DapAn[i];
                }
            }

            klbChinhTa.SelectionStart = klbChinhTa.Text.Length;
            klbChinhTa.SelectionLength = 1;
            klbChinhTa.SelectionFont = new Font(new FontFamily("Times New Roman"), 14);
            klbChinhTa.SelectionColor = Color.Red;
            string strKetQua = "\r\nTỉ lệ câu đúng: " + Count.ToString() + "/" + klbChinhTa.DapAn.Count.ToString();
            if (klbChinhTa.DapAn.Count > 0)
            {
                double dblPhanTram = 1.0 * Count / klbChinhTa.DapAn.Count;
                dblPhanTram *= 100;
                if (dblPhanTram == 100)
                {
                    strKetQua += "\r\nEm giỏi quá, làm đúng tất cả rồi! Tin rằng trong tương lai em sẽ trở thành một vĩ nhân!";
                }
                else if (dblPhanTram >= 80)
                {
                    strKetQua += "\r\nEm làm rất giỏi, nhưng chưa đúng hết! Hãy luyện tập thêm nhé!";
                }
                else if (dblPhanTram >= 70)
                {
                    strKetQua += "\r\nBài này em làm đạt, nhưng chưa được tốt cho lắm, hãy cố gắng hơn nữa nhé!";
                }
                else
                {
                    strKetQua += "\r\nEm cần cố gắng hơn nữa, bài làm như vậy là không thể chấp nhận được đâu, sẽ bị người lớn la đó!";
                }
                klbChinhTa.SelectedText = strKetQua;
            }            
        }
    }
}