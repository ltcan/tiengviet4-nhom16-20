using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using DTO;

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


        //Danh sách vị trí học sinh được quyền chuyển đổi trạng thái khi làm bài.
        public List<Tu> DanhSachTu;
        
        public KhungLamBai():base()
        {
            DanhSachTu = new List<Tu>();
            TinhTrangCaret = TinhTrangCaret.Show;
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
        public void DocDe(string DuongDanDenFilertf, string DanhSachSoQuiUoc)
        {
            DanhSachSoQuiUoc = DanhSachSoQuiUoc.Replace(" ", "");
            string[] DanhSachSoQuiUocs = DanhSachSoQuiUoc.Split(',');
            DanhSachTu.Clear();
            TinhTrangBaiLam = TinhTrang.DangLamBai;
            ReadOnly = false;
            RichTextBox rtbTam = new RichTextBox();
            rtbTam.LoadFile(DuongDanDenFilertf);
            DanhSachTu.Clear();
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
            LoadFile(DuongDanDenFilertf);
            if (DanhSachTu.Count > 0)
            {
                SelectionStart = DanhSachTu[0].ViTri;
            }
        }

        //Lấy vị trí khoảng trống hiện tại mà dấu nhắc đang ở đó, nếu blnLast == true
        //dấu nhắc được chấp nhận nếu ở sau vị trí cuối cùng của khoảng trống 1 vị trí.
        int VitriKhoangTrong(bool blnLast)
        {
            for (int i = 0; i < DanhSachTu.Count; ++i)
            {
                if (DanhSachTu[i].TenLoaiTu == "KhoangTrong")
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
                int intVitriKhoangTrong = VitriKhoangTrong(false);
                if (intVitriKhoangTrong != -1)
                {
                    KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intVitriKhoangTrong];
                    DanhSachTu.Remove(DanhSachTu[intVitriKhoangTrong]);

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
                    DanhSachTu.Add(ktKhoangTrong);
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (TinhTrangBaiLam == TinhTrang.DangLamBai)
            {
                if (keyData == (Keys.Shift | Keys.Back) || keyData == (Keys.Control | Keys.Back))
                {
                    keyData = Keys.Back;
                    int intVitriKhoangTrongLast = VitriKhoangTrong(true);
                    if (intVitriKhoangTrongLast > -1)
                    {
                        SelectionStart = DanhSachTu[intVitriKhoangTrongLast].ViTri;
                        SelectionLength = DanhSachTu[intVitriKhoangTrongLast].NoiDung.Length;
                    }
                }

                if (keyData == Keys.Back)
                {
                    int intVitriKhoangTrongLast = VitriKhoangTrong(true);
                    if (intVitriKhoangTrongLast > -1)
                    {
                        KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intVitriKhoangTrongLast];
                        DanhSachTu.Remove(DanhSachTu[intVitriKhoangTrongLast]);
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
                        DanhSachTu.Add(ktKhoangTrong);
                    }
                    return true;
                }

                if (keyData == (Keys.Shift | Keys.Delete) || keyData == (Keys.Control | Keys.Delete))
                {
                    keyData = Keys.Delete;
                    int intVitriKhoangTrongLast = VitriKhoangTrong(true);
                    if (intVitriKhoangTrongLast > -1)
                    {
                        SelectionStart = DanhSachTu[intVitriKhoangTrongLast].ViTri;
                        SelectionLength = DanhSachTu[intVitriKhoangTrongLast].NoiDung.Length;
                    }
                }

                if (keyData == Keys.Delete)
                {
                    int intVitriKhoangTrong = VitriKhoangTrong(false);
                    if (intVitriKhoangTrong > -1)
                    {
                        KhoangTrong ktKhoangTrong = (KhoangTrong)DanhSachTu[intVitriKhoangTrong];
                        DanhSachTu.Remove(DanhSachTu[intVitriKhoangTrong]);
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
                        DanhSachTu.Add(ktKhoangTrong);
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
                int intSelectionStart = SelectionStart;
                int intSelectionLength = SelectionLength;
                
                for (int i = 0; i < DanhSachTu.Count; ++i)
                {
                    if (DanhSachTu[i].TenLoaiTu == "NhomTu")
                    {
                        int[] arrintVitriChon = ((NhomTu)DanhSachTu[i]).LayViTriChonVaThayDoiTinhTrangChonTuNeuO(intSelectionStart);
                        if (arrintVitriChon[1] != -1)
                        {
                            if (arrintVitriChon[0] != -1)
                            {
                                SelectionStart = DanhSachTu[i].ViTri - 1;
                                SelectionLength = 1;
                                Color clDefault = SelectionColor;
                                System.Drawing.Font fntDefault = SelectionFont;
                                int[] arrintVitri = ((NhomTu)DanhSachTu[i]).LayKhoangViTriCuaTuTai(arrintVitriChon[0]);
                                SelectionStart = arrintVitri[0];
                                SelectionLength = arrintVitri[1];
                                SelectionFont = fntDefault;
                                SelectionColor = clDefault;
                            }

                            if (arrintVitriChon[0] != arrintVitriChon[1])
                            {
                                int[] arrintVitri = ((NhomTu)DanhSachTu[i]).LayKhoangViTriCuaTuTai(arrintVitriChon[1]);
                                SelectionStart = arrintVitri[0];
                                SelectionLength = 1;
                                int j = 0;
                                while (SelectedText == " " && j <= arrintVitri[1])
                                {
                                    ++SelectionStart;
                                    ++j;
                                }
                                SelectionLength = arrintVitri[1] - j;
                                while (SelectedText == " " && SelectionLength > 0)
                                {
                                    --SelectionLength;
                                }
                                SelectionFont = new Font(SelectionFont.FontFamily, SelectionFont.Size, FontStyle.Underline);
                                SelectionColor = Color.Blue;
                            }
                            break;
                        }
                    }
                }
                SelectionStart = intSelectionStart;
                SelectionLength = intSelectionLength;
            }
            else
            {
                base.OnMouseClick(e);
            }
        }
        
        protected override void OnMouseMove(MouseEventArgs e)
        {
            int intCharIndex = GetCharIndexFromPosition(e.Location);
            for (int i = 0; i < DanhSachTu.Count; ++i)
            {
                if (DanhSachTu[i].TenLoaiTu == "NhomTu")
                {
                    if (intCharIndex >= DanhSachTu[i].ViTri && intCharIndex < DanhSachTu[i].ViTri + DanhSachTu[i].NoiDung.Length)
                    {
                        Cursor = Cursors.Hand;
                        return;
                    }
                }
            }
            if (Cursor == Cursors.Hand)
            {
                Cursor = Cursors.IBeam;
            }
        }
    }
}
