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
    public partial class ChinhTaForm : Form
    {
        enum ChucNang{KhongXacDinh, ChinhTa, NgheVaViet, GiaiCauDo}
        ChucNang ChucNangHienTai;

        // LVL
        // Lưu trữ form cha để điều khiển form cha
        private ChonBaiHocForm frmParent;

        //Dành cho phần chính tả:
        private List<FileLuyenTapDTO> DanhSachDeBaiChinhTa;
        private int DeChinhTaHienTai;
        private string strBaiVan;
        //Kết thúc phần khai báo dành cho phần chính tả.
        
        public ChinhTaForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            //Khởi tạo chung:
            InitializeComponent();
            ChucNangHienTai = ChucNang.KhongXacDinh;
            LoiKhuyen();
            //Kết thúc khởi tạo chung.

            //Khởi tạo phần chức năng chính tả:
            klbChinhTa.Visible = false;
            klbChinhTa.QuanLyDau = new QuanLyDau(Application.StartupPath + @"\CaiDat\QuyTacDau.dat");
            DanhSachDeBaiChinhTa = FileLuyenTapBUS.LayFileTheoMaBaiHoc(strMaBaiHoc);
            DeChinhTaHienTai = -1;

            frmParent = MyParent;

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
            //btnThanhDieuHuongTren.Location.X = 215;
            //btnThanhDieuHuongTren.Location.Y = 9;
            ChucNangHienTai = ChucNang.ChinhTa;
            pnlNgheVaViet.Expanded = false;
            //pnlGiaiCauDo.Expanded = false;
            if (DanhSachDeBaiChinhTa.Count > 0)
            {
                klbChinhTa.Visible = true;
                klbChinhTa.TinhTrangBaiLam = TinhTrang.DangLamBai;

                lblThongBao.Visible = false;
                DeChinhTaHienTai = 0;
                Invalidate();
                HienThiBaiHoc();
                if (DanhSachDeBaiChinhTa.Count == 1)
                {
                    picCTCauTiepTheo.Visible = false;
                }
                else
                {
                    picCTCauTiepTheo.Visible = true;
                }
                picCTCauTruoc.Visible = false;
                picCTKetQua.Visible = true;
            }
            else
            {
                DeChinhTaHienTai = -1;
                MessageBox.Show("Dữ liệu của bài học này đã bị mất");
            }
            
        }

        private void btnNgheVaViet_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ChucNangHienTai = ChucNang.NgheVaViet;
            klbChinhTa.Visible = false;
            picCTCauTiepTheo.Visible = false;
            picCTCauTruoc.Visible = false;
            picCTKetQua.Visible = false;           
            pnlGiaiCauDo.Expanded = false;

            pnlNgheVaViet.AnimationTime = 1000;
            pnlNgheVaViet.Expanded = true;
            pnlNgheVaViet.AnimationTime = 100;
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
            else
            {
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
            frmParent.Close();
            Application.Exit();  
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
            frmParent.Show();
            frmParent.Cursor = Cursors.Default;
        }

        private void HienThiBaiHoc()
        {
            if (DeChinhTaHienTai > -1)
            {
                klbChinhTa.DocDe(DanhSachDeBaiChinhTa[DeChinhTaHienTai].FileNoiDung, DanhSachDeBaiChinhTa[DeChinhTaHienTai].FileDapAn, "10, 15, 50");
                strBaiVan = klbChinhTa.Rtf;
            }
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            if (DeChinhTaHienTai < DanhSachDeBaiChinhTa.Count - 1 && DeChinhTaHienTai > -1)
            {
                ++DeChinhTaHienTai;
                Invalidate();
                HienThiBaiHoc();
                if (DeChinhTaHienTai == DanhSachDeBaiChinhTa.Count - 1)
                {
                    picCTCauTiepTheo.Visible = false;
                }

                if (DeChinhTaHienTai > 0)
                {
                    picCTCauTruoc.Visible = true;
                }
            }
        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            if (DeChinhTaHienTai > 0)
            {
                --DeChinhTaHienTai;
                Invalidate();
                HienThiBaiHoc();
                if (DeChinhTaHienTai == 0)
                {
                    picCTCauTruoc.Visible = false;
                }

                if (DeChinhTaHienTai < DanhSachDeBaiChinhTa.Count - 1)
                {
                    picCTCauTiepTheo.Visible = true;
                }
            }
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
            klbChinhTa.Rtf = strBaiVan;
            for (int i = 0; i < klbChinhTa.DapAn.Count; ++i)
            {
                Tu tTu = klbChinhTa.DanhSachTu[i];
                if (tTu.TenLoaiTu == "KhoangTrong")
                {
                    string strDapAnNguoiDungNhap = tTu.NoiDung.Replace(".", "");
                    //Quy: remove khoang trang:
                    strDapAnNguoiDungNhap = strDapAnNguoiDungNhap.Trim();
                    for (int j = 1; j < strDapAnNguoiDungNhap.Length; ++j)
                    {
                        if (strDapAnNguoiDungNhap[j] == ' ')
                        {
                            int k = 1;
                            while (j + k < strDapAnNguoiDungNhap.Length && strDapAnNguoiDungNhap[j + k] == ' ')
                            {
                                ++k;
                            }
                            if (k > 1)
                            {
                                strDapAnNguoiDungNhap = strDapAnNguoiDungNhap.Remove(j + 1, k - 1);
                            }
                        }
                    }
                    //Quy

                    int m1 = tTu.ViTri;
                    int m2 = tTu.NoiDung.Length;
                    int m3 = klbChinhTa.DapAn[i].Length;
                    klbChinhTa.SelectionStart = (m1 + m2 - m3) - (m2 - m3 + 1)/2;
                    klbChinhTa.SelectionLength = m3;

                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2);
                    // Region Le Van Long: sua lai thanh compare no case
                    if (String.Compare(strDapAnNguoiDungNhap, klbChinhTa.DapAn[i], true) == 0)
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
                    klbChinhTa.SelectionStart = tTu.ViTri + tTu.NoiDung.IndexOf(klbChinhTa.DapAn[i]); ;
                    klbChinhTa.SelectionLength = klbChinhTa.DapAn[i].Length;
                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2, FontStyle.Underline);
                    
                    if (((NhomTu)tTu).LayTuDaChon() == klbChinhTa.DapAn[i])
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
                    
                }
                else if (tTu.TenLoaiTu == "TuInNghieng")
                {
                    int m1 = tTu.ViTri;
                    int m2 = tTu.NoiDung.Length;
                    klbChinhTa.SelectionStart = m1;
                    klbChinhTa.SelectionLength = m2;
                    Font font = new Font(klbChinhTa.Font.Name, klbChinhTa.Font.Size + 2);

                    // Le Van Long: Sua lai compare no case
                    if (String.Compare(((TuInNghieng)tTu).NoiDung, klbChinhTa.DapAn[i]) == 0)
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

        private void ChinhTaForm_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = true;

            //picBatDau.Visible = true;
            //lblThongBao.Visible = true;

            //klbChinhTa.Visible = true;
            //klbChinhTa.TinhTrangBaiLam = TinhTrang.DangLamBai;
            //picCTCauTiepTheo.Visible = true;
            //picCTCauTruoc.Visible = true;
            //picCTKetQua.Visible = true;
            //pnlGiaiCauDo.Expanded = false;
            //pnlGiaiCauDo.Expanded = false;
            //picCTCauTruoc.Visible = false;
            
            frmParent.Hide();
        }
    }
}