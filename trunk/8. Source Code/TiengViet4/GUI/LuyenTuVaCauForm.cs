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
        const int CHIEU_DAI_CUA_SO_HIEN_THI = 637;
        const int CHIEU_RONG_CUA_SO_HIEN_THI = 307;
        const int CHIEU_DAI_THU_NHO_CUA_SO_HIEN_THI = 330;
        const int LOCATION_X = 80;

        #region Private Properties
        List<FileLuyenTapDTO> DanhSachDeBai;
        int intDeBaiHienTai;
        //string strDapAn;
        
        ChonBaiHocForm frmParent;
        List<int> arrDanhSachCauDuocChon;
        #endregion

        public LuyenTuVaCauForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            InitializeComponent();
            frmParent = MyParent;
            frmParent.Hide();
            try
            {
                DanhSachDeBai = FileLuyenTapBUS.LayFileTheoMaBaiHoc(strMaBaiHoc);
                if (DanhSachDeBai.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho bài học này");
                    frmParent.Show();
                    this.Close();                    
                }
                else
                {
                    this.picCTCauTiepTheo.Visible = false;
                    this.intDeBaiHienTai = 0;
                    this.picCTCauTruoc.Visible = false;
                    this.arrDanhSachCauDuocChon = new List<int>();
                    if (DanhSachDeBai.Count == 1)
                    {
                        this.picCTCauTiepTheo.Visible = false;
                    }
                }            
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                this.Dispose();
            }           
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void LuyenTuVaCau_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            HienThiBaiHoc();
            //tltXemDapAn.SetToolTip(picCTKetQua, "Xem đáp án");

            frmParent.Hide();
            //this.rtfCuaSoDapAn.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.ThanhPhanCau;
        }

        private void HienThiBaiHoc()
        {
            switch (DanhSachDeBai[intDeBaiHienTai].LoaiFileLuyenTap)
            {
                case "LTVC_PLT":
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.PhanLoaiTu;
                    rtfCuaSoHienThi.EnableAutoDragDrop = true;
                    break;
                case "LTVC_TN":
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.TracNghiem;
                    break;
                case "LTVC_NX":
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.NhanXet;
                    break;
                case "LTVC_GN":
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.GhiNho;
                    break;
                case "LTVC_LT":
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.LuyenTap;
                    break;
                //case "LTVC_TPC":
                //    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.ThanhPhanCau;
                    //break;
                default:
                    rtfCuaSoHienThi.LoaiBai = (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.KhongXacDinh;
                    break;
            }

            if (intDeBaiHienTai >= 0 && intDeBaiHienTai < DanhSachDeBai.Count)
            {
                this.rtfCuaSoHienThi.DocDe(DanhSachDeBai[intDeBaiHienTai].FileNoiDung);
            }

            if (DanhSachDeBai[intDeBaiHienTai].FileDapAn == "")
            {
                this.picCTKetQua.Visible = false;
            }
            else
            {
                this.picCTKetQua.Visible = true;
                if ((this.rtfCuaSoHienThi.LoaiBai & (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.PhanLoaiTu) != 0)
                {
                    this.rtfCuaSoHienThi.DocDapAn(DanhSachDeBai[intDeBaiHienTai].FileDapAn);
                }
                //else if ((this.rtfCuaSoHienThi.LoaiBai & (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.ThanhPhanCau)!= 0)
                //{
                //    this.rtfCuaSoHienThi.Location = new Point(40, 107);
                //    this.rtfCuaSoHienThi.Size = new Size(CHIEU_DAI_THU_NHO_CUA_SO_HIEN_THI, CHIEU_RONG_CUA_SO_HIEN_THI);
                //    this.rtfCuaSoDapAn.Visible = true;
                //    int i = this.rtfCuaSoHienThi.DanhSachTu.Count - 1;
                                        
                //    this.rtfCuaSoDapAn.DanhSachCauHoi = new List<CauHoi>(this.rtfCuaSoHienThi.DanhSachCauHoi.Count);
                //    this.rtfCuaSoDapAn.DanhSachTu = new List<Tu>();
                //    while (i >= 0 && this.rtfCuaSoHienThi.DanhSachTu[i].TenLoaiTu != "KhoangTrong")
                //    {
                //        i--;
                //    }
                //    if (i >= 0)
                //    {
                //        this.rtfCuaSoDapAn.DanhSachTu.Add(this.rtfCuaSoHienThi.DanhSachTu[i]);
                //    }
                //    i--;
                //    while (i >= 0 && this.rtfCuaSoHienThi.DanhSachTu[i].TenLoaiTu != "KhoangTrong")
                //    {
                //        i--;
                //    }
                //    if (i >= 0)
                //    {
                //        this.rtfCuaSoDapAn.DanhSachTu.Add(this.rtfCuaSoHienThi.DanhSachTu[i]);
                //    }

                //    // Xuất các câu hỏi
                //    this.rtfCuaSoDapAn.Clear();
                //    this.rtfCuaSoDapAn.DanhSachCauHoi = this.rtfCuaSoHienThi.DanhSachCauHoi;
                //    int intTam = this.rtfCuaSoDapAn.DanhSachCauHoi[0].ViTri;
                //    string strTam = string.Empty;
                //    for (i = 0; i < this.rtfCuaSoDapAn.DanhSachCauHoi.Count; i++)
                //    {
                //        strTam += (this.rtfCuaSoDapAn.DanhSachCauHoi[i].NoiDung);
                //        this.rtfCuaSoDapAn.DanhSachCauHoi[i].ViTri -= intTam;
                //        if (this.rtfCuaSoDapAn.DanhSachCauHoi[i].Loai == LoaiCauHoi.TraLoiViet)
                //        {
                //            strTam += this.rtfCuaSoDapAn.DanhSachTu[this.rtfCuaSoDapAn.DanhSachTu.Count - 1].NoiDung + '\n';
                //        }
                //        else if (this.rtfCuaSoDapAn.DanhSachCauHoi[i].Loai == LoaiCauHoi.TracNghiem)
                //        {
                //            strTam += this.rtfCuaSoDapAn.DanhSachTu[0].NoiDung;
                //        }
                //    }

                //    this.rtfCuaSoDapAn.SelectionStart = 0;
                //    this.rtfCuaSoDapAn.SelectedText = strTam;
                //}
            }            
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            if (this.rtfCuaSoHienThi.TinhTrangLamBai == TinhTrang.DangLamBai)
            {
                this.rtfCuaSoHienThi.TinhTrangLamBai = TinhTrang.XemDapAn;
                if (this.rtfCuaSoHienThi.LoaiBai == (byte)KhungLamBaiLuyenTuVaCau.LoaiBaiTap.PhanLoaiTu)
                {                    
                    this.rtfCuaSoHienThi.XemKetQua();
                }
                else
                {                    
                    this.rtfCuaSoHienThi.Size = new Size(CHIEU_DAI_THU_NHO_CUA_SO_HIEN_THI, this.rtfCuaSoHienThi.Size.Height);
                    this.rtfCuaSoHienThi.Location = new Point(40, rtfCuaSoHienThi.Location.Y);
                    
                    try
                    {
                        this.rtfCuaSoDapAn.LoadFile(DanhSachDeBai[intDeBaiHienTai].FileDapAn);
                        this.rtfCuaSoDapAn.Visible = true;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }

        private void picCTCauTruoc_Click(object sender, EventArgs e)
        {
            intDeBaiHienTai--;
            this.picCTCauTiepTheo.Visible = true;
            if (intDeBaiHienTai == 0)
            {
                this.picCTCauTruoc.Visible = false;
            }
            
            if (this.rtfCuaSoHienThi.EnableAutoDragDrop == true)
            {
                this.rtfCuaSoHienThi.EnableAutoDragDrop = false;
            }
            if (this.rtfCuaSoDapAn.Visible == true)
            {
                this.rtfCuaSoDapAn.Visible = false;
            }
            if (this.rtfCuaSoHienThi.Size.Width != CHIEU_DAI_CUA_SO_HIEN_THI)
            {
                this.rtfCuaSoHienThi.Size = new Size(CHIEU_DAI_CUA_SO_HIEN_THI, this.rtfCuaSoHienThi.Size.Height);
            }
            if (this.rtfCuaSoHienThi.Location.X != LOCATION_X)
            {
                this.rtfCuaSoHienThi.Location = new Point(LOCATION_X, rtfCuaSoHienThi.Location.Y);
            }

            HienThiBaiHoc();
        }

        private void picCTCauTiepTheo_Click(object sender, EventArgs e)
        {
            intDeBaiHienTai++;
            this.picCTCauTruoc.Visible = true;
            if (intDeBaiHienTai == DanhSachDeBai.Count - 1)
            {
                this.picCTCauTiepTheo.Visible = false;
            }

            if (this.rtfCuaSoHienThi.EnableAutoDragDrop == true)
            {
                this.rtfCuaSoHienThi.EnableAutoDragDrop = false;
            }
            if (this.rtfCuaSoDapAn.Visible == true)
            {
                this.rtfCuaSoDapAn.Visible = false;
            }
            if (this.rtfCuaSoHienThi.Size.Width != CHIEU_DAI_CUA_SO_HIEN_THI)
            {
                this.rtfCuaSoHienThi.Size = new Size(CHIEU_DAI_CUA_SO_HIEN_THI, this.rtfCuaSoHienThi.Size.Height);
            }
            if (this.rtfCuaSoHienThi.Location.X != LOCATION_X)
            {
                this.rtfCuaSoHienThi.Location = new Point(LOCATION_X, rtfCuaSoHienThi.Location.Y);
            }

            HienThiBaiHoc();
        }

        //private void btnChuyenCauQua_Click(object sender, EventArgs e)
        //{
        //    if (this.rtfCuaSoHienThi.SelectedText == string.Empty)
        //    {
        //        MessageBox.Show("Em phải chọn một câu ở bên trái trước đã");
        //    }
        //    else
        //    {
        //        int intChiSoCauDuocChon = this.rtfCuaSoHienThi.TuDuocChon.ViTriTrongDanhSach;
        //        int intCauDuocChon = ((Cau)this.rtfCuaSoHienThi.DanhSachTu[intChiSoCauDuocChon]).SoThuTu;
                
        //        int i = 0;
        //        for (i = 0; i < arrDanhSachCauDuocChon.Count; i++)
        //        {
        //            if (arrDanhSachCauDuocChon[i] == intCauDuocChon)
        //            {
        //                MessageBox.Show("Em đã chọn câu này rồi");
        //                return;
        //            }
        //        }

        //        this.rtfCuaSoDapAn.SelectionStart = this.rtfCuaSoDapAn.DanhSachCauHoi[0].ViTriDuLieu;
        //        this.rtfCuaSoDapAn.SelectionLength = 0;
        //        this.rtfCuaSoDapAn.SelectedText = this.rtfCuaSoHienThi.SelectedText + '\n';
        //        this.rtfCuaSoDapAn.DanhSachTu.Add(this.rtfCuaSoHienThi.TuDuocChon);
        //        this.rtfCuaSoDapAn.DanhSachTu[this.rtfCuaSoDapAn.DanhSachTu.Count - 1].ViTri
        //            = this.rtfCuaSoDapAn.DanhSachCauHoi[0].ViTriDuLieu;
        //        this.arrDanhSachCauDuocChon.Add(intCauDuocChon);

        //        // Cập nhật vị trí dữ liệu
        //        for (i = 0; i < this.rtfCuaSoDapAn.DanhSachCauHoi.Count; i++)
        //        {
        //            this.rtfCuaSoDapAn.DanhSachCauHoi[i].ViTriDuLieu +=
        //                this.rtfCuaSoHienThi.SelectedText.Length + 1;
        //        }
        //    }
        //}
    }
}
