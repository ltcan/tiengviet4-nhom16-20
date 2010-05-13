using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DTO;
using BUS;

namespace TiengViet4
{
    public class KhungLamBai:TransparentRichTextBox
    {
        //Xác định tình trạng của bài làm: 
        //-BinhThuong: Có thể sửa chữa, thay đổi mọi thứ trên khung bài làm.
        //-LamBai: chỉ có thể thay đổi vị trí khung trống.
        //-DanhGia: khung hiển thị phần đánh giá về bài làm.
        //-XemDapAn: chỉ được xem đáp án.
        public TinhTrang TinhTrangBaiLam
        {
            get;
            set;
        }

        //Tình trạng caret
        public TinhTrangCaret TinhTrangCaret
        {
            get;
            set;
        }

        //Biến quản lý việc chuyển đổi dấu.
        public QuanLyDau QuanLyDau
        {
            get;
            set;
        }
        
        //Danh sách vị trí học sinh được quyền chuyển đổi trạng thái khi làm bài.
        public List<Tu> DanhSachTu;
        //Đáp án của câu hiện tại.
        public List<string> DapAn;

        public KhungLamBai():base()
        {
            DanhSachTu = new List<Tu>();
            DapAn = new List<string>();
            TinhTrangCaret = TinhTrangCaret.Show;
            QuanLyDau = null;
        }

        
        bool LaMotTrongSo(int intSo, string[] strarrDanhSachSo)
        {
            for (int i = 0; i < strarrDanhSachSo.Length; ++i)
            {
                if (intSo.ToString() == strarrDanhSachSo[i])
                {
                    return true;
                }
            }
            return false;
        }

        //DanhSachSoQuiUoc: Danh sách số kí tự '.' được qui ước là vùng có thể đánh chữ.
        public void DocDe(string strFileNoiDung, string strFileDapAn, string strDanhSachSoQuiUoc)
        {
            strDanhSachSoQuiUoc = strDanhSachSoQuiUoc.Replace(" ", "");
            string[] DanhSachSoQuiUocs = strDanhSachSoQuiUoc.Split(',');
            DanhSachTu.Clear();
            TinhTrangBaiLam = TinhTrang.DangLamBai;
            ReadOnly = false;
            RichTextBox rtbTam = new RichTextBox();
            rtbTam.LoadFile(strFileNoiDung);
            DanhSachTu.Clear();
            DapAn.Clear();
            DapAn = ChinhTa.LayDapAn(strFileDapAn);
            bool blnFlag = false;
            
            for (int i = 0; i < rtbTam.Text.Length; ++i)
            {
                rtbTam.SelectionStart = i;
                rtbTam.SelectionLength = 1;
                if (DanhSachTu.Count > 0 && rtbTam.SelectionFont.Italic)
                {
                    Tu tTu = DanhSachTu[DanhSachTu.Count - 1];
                    if (tTu.TenLoaiTu != "TuInNghieng" || i > tTu.ViTri + tTu.NoiDung.Length + 1)
                    {
                        string strTuInNghieng = "";
                        do
                        {
                            strTuInNghieng += rtbTam.SelectedText;
                            rtbTam.SelectionStart++;
                        } while (rtbTam.SelectionFont.Italic);
                        TuInNghieng tinTuIngNghieng = new TuInNghieng();
                        tinTuIngNghieng.ViTri = i;
                        tinTuIngNghieng.NoiDung = strTuInNghieng;
                        DanhSachTu.Add(tinTuIngNghieng);
                    }
                }
                
                if (rtbTam.Text[i] == '.')
                {    
                    int j = 1;
                    while (i + j < rtbTam.Text.Length && rtbTam.Text[i + j] == '.')
                    {
                        ++j;
                    }

                    if (LaMotTrongSo(j, DanhSachSoQuiUocs))
                    {
                        if (!blnFlag)
                        {
                            rtbTam.SelectionStart = i;
                            blnFlag = true;
                        }
                        KhoangTrong ktKhoangTrong = new KhoangTrong();
                        ktKhoangTrong.NoiDung = "";
                        for (int c = 0; c < j; ++c)
                        {
                            ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Insert(0, ".");
                        }
                        ktKhoangTrong.ViTri = i;
                        DanhSachTu.Add(ktKhoangTrong);
                    }

                    i = i + j;
                }
                else if (rtbTam.Text[i] == '(')
                {
                    int intVitriDongNgoac = rtbTam.Text.IndexOf(')', i);
                    if (intVitriDongNgoac > i)
                    {
                        if (!blnFlag)
                        {
                            rtbTam.SelectionStart = i + 1;
                            blnFlag = true;
                        }

                        NhomTu ntNhomTu = new NhomTu();
                        ntNhomTu.ViTri = i + 1;
                        ntNhomTu.NoiDung = rtbTam.Text.Substring(i + 1, intVitriDongNgoac - i - 1);
                        DanhSachTu.Add(ntNhomTu);
                    }
                }
            }
            LoadFile(strFileNoiDung);
            
            if (DanhSachTu.Count > 0)
            {
                SelectionStart = DanhSachTu[0].ViTri;
            }
        }

        //Lấy vị trí LoaiTu hiện tại mà dấu nhắc đang ở đó, nếu blnLast == true
        //dấu nhắc được chấp nhận nếu ở sau vị trí cuối cùng của khoảng trống 1 vị trí.
        int ViTriTu(string strTenLoaiTu, bool blnLast)
        {
            for (int i = 0; i < DanhSachTu.Count; ++i)
            {
                if (DanhSachTu[i].TenLoaiTu == strTenLoaiTu)
                {
                    if (SelectionStart >= DanhSachTu[i].ViTri && SelectionStart < DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length)
                    {
                        return i;
                    }
                    else if (blnLast && SelectionStart == DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        protected override void WndProc(ref Message m)
        {
            if (TinhTrangCaret == TinhTrangCaret.Hide)
            {
                Caret.HideCaret(Handle);
            }
            
            base.WndProc(ref m);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TinhTrangBaiLam == TinhTrang.DangLamBai)
            {
                e.Handled = true;
                int intViTriTu = ViTriTu("KhoangTrong", false);
                if (intViTriTu != -1)
                {
                    KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intViTriTu];
                    DanhSachTu.Remove(DanhSachTu[intViTriTu]);

                    int index = SelectionStart - ktKhoangTrong.ViTri;
                    int removeIndex = ktKhoangTrong.NoiDung.IndexOf('.', index);
                    if (removeIndex >= 0)
                    {
                        ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Remove(removeIndex, 1);
                        ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Insert(index, e.KeyChar.ToString());
                        SelectionStart = ktKhoangTrong.ViTri + removeIndex;
                        SelectionLength = 1;
                        SelectedText = "";
                        SelectionStart = ktKhoangTrong.ViTri + index;
                        SelectionLength = 0;
                        SelectedText = e.KeyChar.ToString();
                    }
                    DanhSachTu.Insert(intViTriTu, ktKhoangTrong);
                }
                else
                {
                    intViTriTu = ViTriTu("TuInNghieng", true);
                    if (intViTriTu > -1)
                    {
                        TuInNghieng tinTu = (TuInNghieng)DanhSachTu[intViTriTu];
                        if (SelectionStart > tinTu.ViTri)
                        {
                            SelectionStart = SelectionStart - 1;
                            SelectionLength = 1;
                            char chrKyTu = SelectedText[0];
                            chrKyTu = QuanLyDau.ChuyenDoi(chrKyTu, e.KeyChar);
                            SelectedText = chrKyTu.ToString();
                            tinTu.NoiDung = tinTu.NoiDung.Remove(SelectionStart - tinTu.ViTri - 1, 1);
                            tinTu.NoiDung = tinTu.NoiDung.Insert(SelectionStart - tinTu.ViTri - 1, chrKyTu.ToString());
                        }
                    }
                }
            }
        }

        protected override void OnSelectionChanged(EventArgs e)
        {
            if (ViTriTu("KhoangTrong", true) > -1 || ViTriTu("TuInNghieng", true) > -1)
            {
                TinhTrangCaret = TinhTrangCaret.Show;
            }
            else
            {
                TinhTrangCaret = TinhTrangCaret.Hide;
            }
            base.OnSelectionChanged(e);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (TinhTrangBaiLam == TinhTrang.DangLamBai)
            {
                if (keyData == Keys.Tab)
                {
                    bool blnFlag = true;
                    for (int i = 0; i < DanhSachTu.Count; ++i)
                    {
                        if (DanhSachTu[i].ViTri > SelectionStart)
                        {
                            blnFlag = false;
                            SelectionStart = DanhSachTu[i].ViTri;
                            break;
                        }
                    }
                    if (blnFlag && DanhSachTu.Count > 0)
                    {
                        SelectionStart = DanhSachTu[0].ViTri;
                    }
                }
                
                if (keyData == (Keys.Shift | Keys.Back) || keyData == (Keys.Control | Keys.Back))
                {
                    keyData = Keys.Back;
                    int intViTriTuLast = ViTriTu("KhoangTrong", true);
                    if (intViTriTuLast > -1)
                    {
                        SelectionStart = DanhSachTu[intViTriTuLast].ViTri;
                        SelectionLength = DanhSachTu[intViTriTuLast].NoiDung.Length;
                    }
                }

                if (keyData == Keys.Back)
                {
                    int intViTriTuLast = ViTriTu("KhoangTrong", true);
                    if (intViTriTuLast > -1)
                    {
                        KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intViTriTuLast];
                        DanhSachTu.Remove(DanhSachTu[intViTriTuLast]);
                        int index = SelectionStart - ktKhoangTrong.ViTri;

                        if (index >= 0 && ((index != 0 || SelectionLength != 0) && SelectionLength <= ktKhoangTrong.NoiDung.Length - index))
                        {
                            string strRemove = "";
                            for (int i = 0; i < SelectionLength; ++i)
                            {
                                strRemove = strRemove.Insert(0, ".");
                            }

                            if (strRemove == "")
                            {
                                SelectionStart = SelectionStart - 1;
                                strRemove = ".";
                            }

                            if (SelectionLength == 0)
                            {
                                index -= 1;
                            }
                            ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Remove(index, strRemove.Length);
                            ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Insert(index, strRemove);

                            SelectionLength = strRemove.Length;
                            SelectedText = strRemove;
                            SelectionLength = 0;
                            SelectionStart = index + ktKhoangTrong.ViTri;
                        }
                        DanhSachTu.Insert(intViTriTuLast, ktKhoangTrong);
                    }
                    return true;
                }

                if (keyData == (Keys.Shift | Keys.Delete) || keyData == (Keys.Control | Keys.Delete))
                {
                    keyData = Keys.Delete;
                    int intViTriTuLast = ViTriTu("KhoangTrong", true);
                    if (intViTriTuLast > -1)
                    {
                        SelectionStart = DanhSachTu[intViTriTuLast].ViTri;
                        SelectionLength = DanhSachTu[intViTriTuLast].NoiDung.Length;
                    }
                }

                if (keyData == Keys.Delete)
                {
                    int intViTriTu = ViTriTu("KhoangTrong", false);
                    if (intViTriTu > -1)
                    {
                        KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intViTriTu];
                        DanhSachTu.Remove(DanhSachTu[intViTriTu]);
                        int index = SelectionStart - ktKhoangTrong.ViTri;
                        if (index > -1 && SelectionLength <= ktKhoangTrong.NoiDung.Length - index)
                        {
                            string strRemove = "";
                            for (int i = 0; i < SelectionLength; ++i)
                            {
                                strRemove = strRemove.Insert(0, ".");
                            }

                            if (strRemove == "")
                            {
                                strRemove = ".";
                            }

                            ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Remove(index, strRemove.Length);
                            ktKhoangTrong.NoiDung = ktKhoangTrong.NoiDung.Insert(index, strRemove);

                            SelectionLength = strRemove.Length;
                            SelectedText = strRemove;
                            SelectionLength = 0;
                            SelectionStart = index + ktKhoangTrong.ViTri + strRemove.Length;
                        }
                        DanhSachTu.Insert(intViTriTu, ktKhoangTrong);
                    }
                    return true;
                }

                if (keyData.ToString() == "Return")
                {
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override void  OnMouseClick(MouseEventArgs e)
        {
            if (TinhTrangBaiLam == TinhTrang.DangLamBai)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Rtf = Rtf;
                for (int i = 0; i < DanhSachTu.Count; ++i)
                {
                    if (DanhSachTu[i].TenLoaiTu == "NhomTu")
                    {
                        int[] arrintVitriChon = ((NhomTu)DanhSachTu[i]).LayViTriChonVaThayDoiTinhTrangChonTuNeuO(SelectionStart);
                        if (arrintVitriChon[1] != -1)
                        {
                            int intSelectionStart = SelectionStart;
                            if (arrintVitriChon[0] != -1)
                            {
                                rtb.SelectionStart = DanhSachTu[i].ViTri - 1;
                                rtb.SelectionLength = 1;
                                Color clDefault = rtb.SelectionColor;
                                System.Drawing.Font fntDefault = rtb.SelectionFont;
                                int[] arrintVitri = ((NhomTu)DanhSachTu[i]).LayKhoangViTriCuaTuTai(arrintVitriChon[0]);
                                rtb.SelectionStart = arrintVitri[0];
                                rtb.SelectionLength = arrintVitri[1];
                                rtb.SelectionFont = fntDefault;
                                rtb.SelectionColor = clDefault;
                            }

                            if (arrintVitriChon[0] != arrintVitriChon[1])
                            {
                                int[] arrintVitri = ((NhomTu)DanhSachTu[i]).LayKhoangViTriCuaTuTai(arrintVitriChon[1]);
                                rtb.SelectionStart = arrintVitri[0];
                                rtb.SelectionLength = 1;
                                int j = 0;
                                while (rtb.SelectedText == " " && j <= arrintVitri[1])
                                {
                                    ++rtb.SelectionStart;
                                    ++j;
                                }
                                rtb.SelectionLength = arrintVitri[1] - j;
                                while (rtb.SelectedText == " " && rtb.SelectionLength > 0)
                                {
                                    --rtb.SelectionLength;
                                }
                                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, rtb.SelectionFont.Size, FontStyle.Underline);
                                rtb.SelectionColor = Color.Blue;
                            }
                            TinhTrangCaret = TinhTrangCaret.Hide;
                            Rtf = rtb.Rtf;
                            SelectionStart = intSelectionStart;
                            break;
                        }
                    }
                }
            }
            else
            {
                base.OnMouseClick(e);
            }
        }
        
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int intCharIndex = GetCharIndexFromPosition(e.Location);
            for (int i = 0; i < DanhSachTu.Count; ++i)
            {
                if (intCharIndex >= DanhSachTu[i].ViTri && intCharIndex < DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length)
                {
                    if (DanhSachTu[i].TenLoaiTu == "NhomTu")
                    {
                        Cursor = Cursors.Hand;
                    }
                    return;
                }
            }
            if (Cursor == Cursors.Hand)
            {
                Cursor = Cursors.IBeam;
            }
        }
    }
}
