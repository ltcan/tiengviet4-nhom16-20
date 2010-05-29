using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using DTO;
using BUS;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace TiengViet4
{
    public partial class KhungLamBaiLuyenTuVaCau : TransparentRichTextBox
    {
        public KhungLamBaiLuyenTuVaCau()
        {
            InitializeComponent();
            LoaiBai = 0;
            tTuDuocChon = new NhomTuLTVC();
            //blnDuocDrop = false;
        }

        public KhungLamBaiLuyenTuVaCau(IContainer container)
        {
            container.Add(this);
            LoaiBai = 0;
            tTuDuocChon = new NhomTuLTVC();
            tTuDuocChon.DaDuocChon = false;
            MyCaret = TinhTrangCaret.Show;
            InitializeComponent();
        }
        #region Properties
        public enum LoaiBaiTap
        {
            KhongXacDinh = 0x00,
            PhanLoaiTu = 0x01,
            TracNghiem = 0x02,
            NhanXet = 0x04,
            GhiNho = 0x08,
            LuyenTap = 0x10,
            //ThanhPhanCau = 0x20
        }

        byte intLoaiBai;

        public byte LoaiBai
        {
            get { return intLoaiBai; }
            set { intLoaiBai = value; }
        }
        List<Tu> lstDanhSachTu;     // Dành cho bài phân loại từ

        public List<Tu> DanhSachTu
        {
            get { return lstDanhSachTu; }
            set { lstDanhSachTu = value; }
        }
        TinhTrang ttTinhTrangLamBai;

        public TinhTrang TinhTrangLamBai
        {
            get { return ttTinhTrangLamBai; }
            set { ttTinhTrangLamBai = value; }
        }

        private NhomTuLTVC tTuDuocChon;

        public NhomTuLTVC TuDuocChon
        {
            get { return tTuDuocChon; }
            set { tTuDuocChon = value; }
        }
        
        TinhTrangCaret ttcCaret;

        public TinhTrangCaret MyCaret
        {
            get { return ttcCaret; }
            set { ttcCaret = value; }
        }

        string[] strDapAnTungCau;

        List<CauHoi> lstDanhSachCauHoi;

        public List<CauHoi> DanhSachCauHoi
        {
            get { return lstDanhSachCauHoi; }
            set { lstDanhSachCauHoi = value; }
        }

        #endregion

        #region Methods
        // Đọc nội dung trong file và phân tách
        public void DocDe(string strPath)
        {            
            try
            {
                if (this.LoaiBai != (byte)LoaiBaiTap.GhiNho)
                {
                    RichTextBox rtfTam = new RichTextBox();
                    rtfTam.LoadFile(strPath);
                    int i = 0;
                    //if ((intLoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)      // Phép AND bit
                    //{
                    //intLoaiBai = (byte)LoaiBaiTap.PhanLoaiTu;
                    rtfTam.SelectionLength = 1;
                    lstDanhSachTu = new List<Tu>();
                    lstDanhSachCauHoi = new List<CauHoi>();

                    i = 0;
                    while (i < rtfTam.Text.Length)
                    {
                        rtfTam.SelectionStart = i;
                        if (rtfTam.SelectionFont.Italic && rtfTam.SelectedText != " "
                            && (intLoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)
                        {
                            NhomTuLTVC ntTu = new NhomTuLTVC();
                            ntTu.ViTri = i;

                            do
                            {
                                ntTu.NoiDung += rtfTam.SelectedText;
                                rtfTam.SelectionStart++;
                            } while (rtfTam.SelectionFont.Italic && rtfTam.SelectedText != ","
                                && rtfTam.SelectedText != ".");

                            i += ntTu.NoiDung.Length;
                            lstDanhSachTu.Add(ntTu);
                        }
                        else if (rtfTam.SelectedText == "." && i < rtfTam.Text.Length - 5)
                        {
                            string strTam = rtfTam.Text.Substring(i, 4);
                            if (strTam == "....")
                            {
                                KhoangTrongLTVC ktKhoangTrong = new KhoangTrongLTVC();
                                ktKhoangTrong.ViTri = i;
                                //if ((this.LoaiBai & (byte)LoaiBaiTap.ThanhPhanCau) != 0)
                                //{
                                //    ktKhoangTrong.ViTri -= DanhSachCauHoi[0].ViTri;
                                //}

                                do
                                {
                                    ktKhoangTrong.NoiDung += rtfTam.SelectedText;
                                    rtfTam.SelectionStart++;
                                } while (rtfTam.SelectionStart < rtfTam.Text.Length && rtfTam.SelectedText == ".");

                                i += ktKhoangTrong.NoiDung.Length;
                                lstDanhSachTu.Add(ktKhoangTrong);
                            }
                        }
                        //else if (rtfTam.SelectedText == "<" && (this.LoaiBai & (byte)LoaiBaiTap.ThanhPhanCau) != 0)
                        //{
                        //    Cau cCau = new Cau();
                        //    cCau.ViTri = i;
                        //    string strSoThuTu = string.Empty;
                        //    int j = i + 1;
                        //    do
                        //    {
                        //        strSoThuTu += rtfTam.Text[j];
                        //        j++;
                        //    } while (rtfTam.Text[j] != '>');
                        //    cCau.SoThuTu = int.Parse(strSoThuTu);

                        //    do
                        //    {
                        //        cCau.NoiDung += rtfTam.SelectedText;
                        //        rtfTam.SelectionStart++;
                        //    } while (rtfTam.SelectedText != ".");

                        //    cCau.NoiDung += ".";
                        //    i += cCau.NoiDung.Length;
                        //    lstDanhSachTu.Add(cCau);
                        //}
                        //// Phần này dành cho việc chọn câu và phân tách chủ ngữ vị ngữ
                        //// Tuy nhiên chưa làm xong
                        //else if (rtfTam.SelectedText == "@" && (this.LoaiBai & (byte)LoaiBaiTap.ThanhPhanCau) != 0)
                        //{
                        //    CauHoi chCauHoi = new CauHoi();

                        //    chCauHoi.ViTri = i;
                        //    string strChuoiDinhDang = string.Empty;

                        //    // Xóa ký tự @
                        //    rtfTam.SelectedText = string.Empty;
                        //    rtfTam.SelectionLength = 1;
                        //    while (rtfTam.SelectedText != "#")
                        //    {
                        //        strChuoiDinhDang += rtfTam.SelectedText; 
                        //        rtfTam.SelectedText = string.Empty;
                        //        rtfTam.SelectionLength = 1;                                                               
                        //    } 
                        //    // Xóa nốt ký tự #
                        //    rtfTam.SelectedText = string.Empty;
                        //    rtfTam.SelectionLength = 1;

                        //    int intLoaiCauHoi = int.Parse(strChuoiDinhDang);
                        //    switch(intLoaiCauHoi)
                        //    {
                        //        case 1:
                        //            chCauHoi.Loai = LoaiCauHoi.TimCau;
                        //            break;
                        //        case 4:
                        //            chCauHoi.Loai = LoaiCauHoi.TracNghiem;
                        //            break;
                        //        case 3:
                        //            chCauHoi.Loai = LoaiCauHoi.TraLoiViet;
                        //            break;
                        //        case 2:
                        //            chCauHoi.Loai = LoaiCauHoi.XacDinhThanhPhan;
                        //            break;
                        //        default:
                        //            throw new Exception("Đề bài nhập liệu không đúng quy định");
                        //    }

                        //    while (rtfTam.SelectedText != "@" && rtfTam.SelectionStart < rtfTam.Text.Length)
                        //    {
                        //        if ((intLoaiCauHoi == 3 || intLoaiCauHoi == 4) && rtfTam.SelectedText == ".")
                        //        {
                        //            if (rtfTam.Text.Substring(rtfTam.SelectionStart, 4) == "....")
                        //            {
                        //                break;
                        //            }
                        //        }
                        //        chCauHoi.NoiDung += rtfTam.SelectedText;
                        //        rtfTam.SelectionStart++;
                        //    }
                        //    //chCauHoi.NoiDung += '\n';
                        //    chCauHoi.ViTriDuLieu = chCauHoi.NoiDung.Length;
                        //    i += chCauHoi.NoiDung.Length - 1;
                        //    DanhSachCauHoi.Add(chCauHoi);
                        //}

                        i++;
                    }

                    // Nếu là dạng bài thành phần câu thì xóa bỏ phần câu hỏi
                    // để chuyển sang text box đáp án
                    //if ((this.LoaiBai & (byte)LoaiBaiTap.ThanhPhanCau) != 0)
                    //{
                    //    if (DanhSachCauHoi.Count > 0)
                    //    {
                    //        rtfTam.SelectionStart = DanhSachCauHoi[0].ViTri;
                    //        rtfTam.SelectionLength = rtfTam.Text.Length - (DanhSachCauHoi[0].ViTri);
                    //        rtfTam.SelectedText = string.Empty;
                    //    }
                    //}
                    this.Rtf = rtfTam.Rtf;
                }
                else
                {
                    this.LoadFile(strPath);
                }
                if ((this.LoaiBai & ((byte)LoaiBaiTap.GhiNho
                    | (byte)LoaiBaiTap.PhanLoaiTu)) != 0)
                {
                    MyCaret = TinhTrangCaret.Hide;
                }

                ttTinhTrangLamBai = TinhTrang.DangLamBai;
                //this.Invalidate();
            }
            catch (Exception Ex)
            {
                //DialogResult Result = MessageBox.Show("Đường dẫn đến tập tin " + strPath + " không đúng\r\nBạn có muốn tìm tập tin này?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //if (Result == DialogResult.OK)
                //{
                //    OpenFileDialog dlgOpenFile = new OpenFileDialog();
                //    dlgOpenFile.InitialDirectory = strPath;
                //    dlgOpenFile.Filter = "Tập tin bài giảng|*.rtf";
                //    DialogResult OpenResult = dlgOpenFile.ShowDialog();
                //    if (OpenResult == DialogResult.OK)
                //    {
                //        DocDe(dlgOpenFile.FileName);
                //    }
                //}
                MessageBox.Show(Ex.Message);
            }
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            // Tự điều chỉnh kết quả
            drgevent.Effect = DragDropEffects.None;
            int i, j;

            if (TinhTrangLamBai == TinhTrang.DangLamBai && (LoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)
            {
                for (i = 0; i < DanhSachTu.Count; i++)
                {
                    Tu tTu = DanhSachTu[i];
                    //int intViTriDrop = this.GetCharIndexFromPosition(new Point(drgevent.X, drgevent.Y));
                    if (tTu.TenLoaiTu == "KhoangTrong" 
                        && tTu.ViTri + ((KhoangTrongLTVC)tTu).ViTriDuLieu <= this.SelectionStart
                        && this.SelectionStart <= tTu.ViTri + tTu.NoiDung.Length)
                    {
                        int intViTriDuocChonCu = this.SelectionStart;
                        Font fntFontCu = this.SelectionFont;

                        // Thay các dấu ... bằng từ được kéo
                        int intSelectedLength = tTuDuocChon.NoiDung.Length;
                        this.SelectionStart = tTu.ViTri + ((KhoangTrongLTVC)tTu).ViTriDuLieu;
                        this.SelectionLength = intSelectedLength;
                        this.SelectedText = tTuDuocChon.NoiDung;
                        this.SelectionFont = fntFontCu;

                        // Xóa từ được kéo
                        this.SelectionStart = tTuDuocChon.ViTri;                        
                        this.SelectionLength = intSelectedLength;
                        this.SelectedText = "";

                        this.SelectionStart = intViTriDuocChonCu;

                        // Cập nhật lại vị trí các từ
                        for (j = 0; j < DanhSachTu.Count; j++)
                        {
                            if (DanhSachTu[j].ViTri > tTuDuocChon.ViTri)
                            {
                                DanhSachTu[j].ViTri -= intSelectedLength;
                            }
                        }

                        // Cập nhật lại cho từ vừa được kéo
                        DanhSachTu[tTuDuocChon.ViTriTrongDanhSach].ViTri = DanhSachTu[i].ViTri
                            + ((KhoangTrongLTVC)DanhSachTu[i]).ViTriDuLieu;

                        if (((NhomTuLTVC)DanhSachTu[tTuDuocChon.ViTriTrongDanhSach]).DaDuocKeo == false)
                        {                           
                            ((NhomTuLTVC)DanhSachTu[tTuDuocChon.ViTriTrongDanhSach]).DaDuocKeo = true;
                        }
                        else
                        {
                            // Cập nhật lại vị trí dữ liệu cho khoảng trống
                            for (j = 0; j < DanhSachTu.Count; j++)
                            {
                                if (DanhSachTu[j].TenLoaiTu == "KhoangTrong")
                                {
                                    if (tTuDuocChon.ViTri >= DanhSachTu[j].ViTri
                                        && tTuDuocChon.ViTri <= DanhSachTu[j].ViTri + ((KhoangTrongLTVC)DanhSachTu[j]).ViTriDuLieu)
                                    {
                                        ((KhoangTrongLTVC)DanhSachTu[j]).ViTriDuLieu -= intSelectedLength;
                                        break;
                                    }
                                }
                            }

                        }

                        ((KhoangTrongLTVC)DanhSachTu[i]).ViTriDuLieu += intSelectedLength;

                        return;
                    }
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (this.TinhTrangLamBai == TinhTrang.DangLamBai)
            {
                int intViTriChon = this.GetCharIndexFromPosition(e.Location);
                int intOldSelectionStart = this.SelectionStart;
                int intOldSelectionLength = this.SelectionLength;

                if ((LoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)
                {
                    RichTextBox rtfBuf = new RichTextBox();
                    rtfBuf.Rtf = this.Rtf;
                    //int intSelectionStart = this.SelectionStart;                    

                    // Neu chuot khong di qua vi tri tu dac biet
                    // thi khoi phuc lai trang thai cu cua tu duoc chon truoc do
                    if (tTuDuocChon.DaDuocChon == true &&
                        (intViTriChon < tTuDuocChon.ViTri || intViTriChon > tTuDuocChon.ViTri + tTuDuocChon.NoiDung.Length))
                    {
                        // Lay font ban dau de khoi phuc lai font cho tu vua duoc chon
                        rtfBuf.SelectionStart = 0;
                        Font fntDefault = rtfBuf.SelectionFont;

                        rtfBuf.SelectionStart = tTuDuocChon.ViTri;
                        rtfBuf.SelectionLength = tTuDuocChon.NoiDung.Length;
                        rtfBuf.SelectionFont = new Font(fntDefault, FontStyle.Italic);
                        //rtfBuf.BackColor = Color.Transparent;
                        rtfBuf.SelectionColor = Color.Black;
                        //rtfBuf.ShowSelectionMargin = false;

                        this.Rtf = rtfBuf.Rtf;
                        this.SelectionStart = intOldSelectionStart;
                        this.SelectionLength = intOldSelectionLength;
                        //this.Cursor = Cursors.Default;
                        tTuDuocChon.DaDuocChon = false;
                        //this.Invalidate();
                    }

                    for (int i = 0; i < DanhSachTu.Count; i++)
                    {
                        if (intViTriChon >= DanhSachTu[i].ViTri &&
                            intViTriChon <= DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length
                            && DanhSachTu[i].TenLoaiTu == "NhomTuLTVC")
                        {
                            Font fntOld = this.SelectionFont;
                            rtfBuf.SelectionStart = DanhSachTu[i].ViTri;
                            rtfBuf.SelectionLength = DanhSachTu[i].NoiDung.Length;
                            rtfBuf.SelectionFont = new Font(fntOld, FontStyle.Underline | FontStyle.Italic);
                            rtfBuf.SelectionColor = Color.Blue;
                            //rtfBuf.ShowSelectionMargin = true;
                            //rtfBuf.SelectionBackColor = Color.LightGray;

                            // Luu lai tu vua duoc chon de khoi phuc lai trang thai cu
                            // khi chuot roi khoi
                            tTuDuocChon.ViTri = DanhSachTu[i].ViTri;
                            tTuDuocChon.NoiDung = DanhSachTu[i].NoiDung;
                            tTuDuocChon.DaDuocChon = true;
                            tTuDuocChon.ViTriTrongDanhSach = i;

                            this.Rtf = rtfBuf.Rtf;
                            this.SelectionStart = DanhSachTu[i].ViTri;
                            this.SelectionLength = DanhSachTu[i].NoiDung.Length;
                            if (this.Text.Substring(SelectionStart + SelectionLength, 2) == ", ")
                            {
                                this.SelectionLength += 2;
                            }
                            tTuDuocChon.NoiDung += ", ";
                            break;
                        }
                    }
                }
            }     
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if ((LoaiBai & ((byte)LoaiBaiTap.PhanLoaiTu))!= 0 
                && TinhTrangLamBai == TinhTrang.DangLamBai)
            {
                int intIndex = GetCharIndexFromPosition(e.Location);
                for (int i = 0; i < DanhSachTu.Count; i++)
                {
                    if (intIndex >= DanhSachTu[i].ViTri &&
                                intIndex <= DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length
                                && (DanhSachTu[i].TenLoaiTu == "NhomTuLTVC"))
                    {
                        this.Cursor = Cursors.Hand;
                        return;
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        protected override void WndProc(ref Message m)
        {
            if (MyCaret == TinhTrangCaret.Hide)
            {
                Caret.HideCaret(Handle);
            }
            else
            {
                Caret.ShowCaret(Handle);
            }

            base.WndProc(ref m);
        }

        public void XemKetQua()
        {
            if (TinhTrangLamBai == TinhTrang.XemDapAn)
            {
                int i = DanhSachTu.Count - 1;
                int k = 0;

                int intSoDapAnDung = 0;
                int intTongSoDapAn = 0;

                if ((this.LoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)
                {
                    int intKhoangTrongHienTai = strDapAnTungCau.Length - 1;

                    while (intKhoangTrongHienTai >= 0)
                    {
                        string[] strTungDapAn = strDapAnTungCau[intKhoangTrongHienTai].Split('|');
                        bool[] arrFlag = new bool[strTungDapAn.Length];
                        for (k = 0; k < strTungDapAn.Length; k++)
                        {
                            arrFlag[k] = false;
                        }

                        intTongSoDapAn += strTungDapAn.Length;

                        // Lưu lại font cũ
                        this.SelectionStart = 0;
                        this.SelectionLength = 1;
                        Font fntFontCu = this.SelectionFont;

                        for (k = 0; k < DanhSachTu.Count; k++)
                        {
                            if (DanhSachTu[k].TenLoaiTu == "NhomTuLTVC")
                            {
                                if (DanhSachTu[k].ViTri >= DanhSachTu[i].ViTri
                                    && DanhSachTu[k].ViTri <= (DanhSachTu[i].ViTri + ((KhoangTrongLTVC)DanhSachTu[i]).ViTriDuLieu))
                                {
                                    this.SelectionStart = DanhSachTu[k].ViTri;
                                    this.SelectionLength = DanhSachTu[k].NoiDung.Length;
                                    this.SelectionFont = new Font(fntFontCu, FontStyle.Italic);
                                    Font fntStrikeoutFont = new Font(fntFontCu, FontStyle.Strikeout);

                                    int intViTriDapAn = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(DanhSachTu[k].NoiDung, strTungDapAn);
                                    if (intViTriDapAn != -1)
                                    {
                                        intSoDapAnDung++;
                                        this.SelectionColor = Color.Blue;
                                        arrFlag[intViTriDapAn] = true;
                                    }
                                    else
                                    {
                                        this.SelectionColor = Color.Red;
                                        this.SelectionFont = fntStrikeoutFont;
                                    }
                                }
                            }
                        }

                        // Hiện ra những đáp án còn thiếu
                        string strCacDapAnConThieu = string.Empty;
                        for (k = 0; k < strTungDapAn.Length; k++)
                        {
                            if (arrFlag[k] == false)
                            {
                                strCacDapAnConThieu += (strTungDapAn[k] + ", ");
                            }
                        }
                        this.SelectionStart = DanhSachTu[i].ViTri + ((KhoangTrongLTVC)DanhSachTu[i]).ViTriDuLieu;
                        this.SelectionLength = strCacDapAnConThieu.Length;
                        this.SelectionFont = fntFontCu;
                        this.SelectedText = strCacDapAnConThieu;

                        intKhoangTrongHienTai--;
                        i--;
                    }
                    this.SelectionStart = this.Text.Length;
                    string strKetQua = "\nTỉ lệ đúng: " + intSoDapAnDung.ToString()
                        + "/" + intTongSoDapAn.ToString();
                    this.SelectionLength = strKetQua.Length;
                    this.SelectionFont = new Font("Arrial", 14, FontStyle.Bold | FontStyle.Italic);
                    float fltTiLeDung = (float)intSoDapAnDung / intTongSoDapAn;
                    if (fltTiLeDung > 0.5)
                    {
                        this.SelectionColor = Color.DarkGreen;
                    }
                    else
                    {
                        this.SelectionColor = Color.Red;
                    }
                    this.SelectedText = strKetQua;     
                }
            }
        }

        public void DocDapAn(string strPath)
        {
            try
            {
                string strDapAn = QuanLyFile.LayNoiDung(strPath);
                strDapAnTungCau = strDapAn.Split('#');
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    for (int i = this.DanhSachTu.Count - 1; i >= 0; i--)
        //    {
        //        e.Handled = true;
        //        if (this.DanhSachTu[i].TenLoaiTu == "KhoangTrong"
        //            && this.SelectionStart >= this.DanhSachTu[i].ViTri
        //            && this.SelectionStart <= this.DanhSachTu[i].ViTri + this.DanhSachTu[i].NoiDung.Length)
        //        {
        //            int index = SelectionStart - DanhSachTu[i].ViTri;
        //            int removeIndex = DanhSachTu[i].NoiDung.IndexOf('.', index);
        //            if (removeIndex >= 0)
        //            {
        //                //ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Remove(removeIndex, 1);
        //                //ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Insert(index, e.KeyChar.ToString());
        //                SelectionStart = this.DanhSachTu[i].ViTri + removeIndex;
        //                SelectionLength = 1;
        //                SelectedText = "";
        //                SelectionStart = this.DanhSachTu[i].ViTri + index;
        //                SelectionLength = 0;
        //                SelectedText = e.KeyChar.ToString();
        //            }
        //            break;
        //        }
        //    }           
        //}

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.LoaiBai == (byte)LoaiBaiTap.PhanLoaiTu)
            {
                for (int i = this.DanhSachTu.Count - 1; i >= 0; i--)
                {
                    if (this.DanhSachTu[i].TenLoaiTu == "KhoangTrong"
                        && this.SelectionStart >= this.DanhSachTu[i].ViTri
                        && this.SelectionStart <= this.DanhSachTu[i].ViTri + this.DanhSachTu[i].NoiDung.Length)
                    {
                        this.ttcCaret = TinhTrangCaret.Show;
                        this.SelectionStart = this.DanhSachTu[i].ViTri + ((KhoangTrongLTVC)this.DanhSachTu[i]).ViTriDuLieu;
                        return;
                    }
                }
                this.ttcCaret = TinhTrangCaret.Hide;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {            
            base.OnTextChanged(e);
        }

        #endregion
    }
}
