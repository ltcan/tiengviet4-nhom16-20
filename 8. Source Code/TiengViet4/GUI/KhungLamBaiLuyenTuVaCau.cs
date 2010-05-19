using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using DTO;
using BUS;
using System.Windows.Forms;
using System.IO;

namespace TiengViet4
{
    public partial class KhungLamBaiLuyenTuVaCau : TransparentRichTextBox
    {
        public KhungLamBaiLuyenTuVaCau()
        {
            InitializeComponent();
            LoaiBai = 0;
            //blnDuocDrop = false;
        }

        public KhungLamBaiLuyenTuVaCau(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #region Properties
        enum LoaiBaiTap
        {
            PhanLoaiTu = 0x01,
            TracNghiem = 0x02
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

        // Dành cho chức năng drag và drop
        //private bool blnDuocDrop;       // Cho phép drag và drop
        //int intViTriDrop;
        //int intSelectionLength;

        #endregion

        #region Methods
        // Đọc nội dung trong file và phân tách
        public void DocDe(string strPath)
        {
            RichTextBox rtfTam = new RichTextBox();
            try
            {
                rtfTam.LoadFile(strPath);
                int i = 0;
                if ((intLoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)      // Phép AND bit
                {
                    intLoaiBai = (byte)LoaiBaiTap.PhanLoaiTu;
                    rtfTam.SelectionLength = 1;
                    lstDanhSachTu = new List<Tu>();

                    i = 0;
                    while (i < rtfTam.Text.Length)
                    {
                        rtfTam.SelectionStart = i;
                        if (rtfTam.SelectionFont.Italic)
                        {
                            TuInNghieng tinTu = new TuInNghieng();
                            tinTu.ViTri = i;

                            do
                            {
                                tinTu.NoiDung += rtfTam.SelectedText;
                                rtfTam.SelectionStart++;
                            } while (rtfTam.SelectionFont.Italic && rtfTam.SelectedText != ",");

                            i += (tinTu.NoiDung.Length + 1);
                            lstDanhSachTu.Add(tinTu);
                        }
                        else if (rtfTam.SelectedText == ".")
                        {
                            string strTam = rtfTam.Text.Substring(i, 4);
                            if (strTam == "....")
                            {
                                KhoangTrong_LuyenTuVaCau ktKhoangTrong = new KhoangTrong_LuyenTuVaCau();
                                ktKhoangTrong.ViTri = i;

                                do
                                {
                                    ktKhoangTrong.NoiDung += rtfTam.SelectedText;
                                    rtfTam.SelectionStart++;
                                } while (rtfTam.SelectedText == ".");

                                i += (ktKhoangTrong.NoiDung.Length + 1);
                                lstDanhSachTu.Add(ktKhoangTrong);
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                this.Text = rtfTam.Text;
                ttTinhTrangLamBai = TinhTrang.DangLamBai;
            }
            catch (Exception Ex)
            {
                DialogResult Result = MessageBox.Show("Đường dẫn đến tập tin" + strPath + " không đúng\r\nBạn có muốn tìm tập tin này?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (Result == DialogResult.OK)
                {
                    OpenFileDialog dlgOpenFile = new OpenFileDialog();
                    dlgOpenFile.InitialDirectory = strPath;
                    dlgOpenFile.Filter = "Tập tin bài giảng|*.rtf";
                    DialogResult OpenResult = dlgOpenFile.ShowDialog();
                    if (OpenResult == DialogResult.OK)
                    {
                        DocDe(dlgOpenFile.FileName);
                    }
                }
            }
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            //if ((LoaiBai & (byte)LoaiBaiTap.PhanLoaiTu) != 0)
            //{
                //foreach (Tu tTu in DanhSachTu)
                //{
                //    if (tTu.TenLoaiTu == "KhoangTrong")
                //    {
                //        KhoangTrong_LuyenTuVaCau tTam = new KhoangTrong_LuyenTuVaCau((KhoangTrong_LuyenTuVaCau)tTu);
                //        if (tTam.ViTriDuLieu < (tTam.ViTri + tTam.NoiDung.Length - 10)
                //            && this.SelectionStart <= tTam.ViTriDuLieu)
                //        {                            
            //blnDuocDrop = true;
            //base.OnDragDrop(drgevent);
            //MessageBox.Show(this.Text);
            string strDraggedText = drgevent.Data.GetData(typeof(System.String)).ToString();
            int intSelectedLength = strDraggedText.Length;
            string strLower = strDraggedText.ToLower();
            //drgevent.Data.SetData(strLower);
            //drgevent.Effect = DragDropEffects.Move;
            string strNew;
            int intCurrentSelectionStart = this.SelectionStart;
            string strNew1;
            // Đổi thành chữ thường đồng thời thay thế các dấu '.'
            int intIndex = this.Text.IndexOf(strDraggedText);
            strNew = this.Text.Remove(intIndex, intSelectedLength);
            //strNew1 = this.Text.Replace(strNew.Substring(tTu.ViTriDuLieu, intSelectedLength), strLower);
            //tTu.ViTriDuLieu += intSelectedLength;
            strNew1 = strNew.Remove(this.SelectionStart - intSelectedLength, intSelectedLength);
            //strNew = this.Text.Replace(strNew1.Substring(this.SelectionStart - intSelectedLength, intSelectedLength * 2), strLower);
            this.Text = strNew1;
            this.SelectionStart = intCurrentSelectionStart - intSelectedLength;
            base.OnDragDrop(drgevent);
            //this.Invalidate();        
                //        }
                //    }
                //}
            //} 
        }

        //protected override void OnTextChanged(EventArgs e)
        //{
        //    base.OnTextChanged(e);

        //    if (blnDuocDrop == true)
        //    {
        //        //MessageBox.Show(this.Text);
        //        blnDuocDrop = false;
        //        string strNew = this.Text.Remove(intViTriDrop, intSelectionLength);
        //        this.Text = strNew;
        //    }
        //}        
        #endregion
    }
}
