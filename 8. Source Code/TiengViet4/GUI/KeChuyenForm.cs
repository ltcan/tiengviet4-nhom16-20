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
    public partial class KeChuyenForm : Form
    {
        public string FileNoiDung;
        public string FileHinhAnh;
        public string maBH;
        public string tenCauChuyen;
        ChonBaiHocForm frmParent;
        public KeChuyenForm()
        {
            InitializeComponent();
        }
        

        public KeChuyenForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            InitializeComponent();
            frmParent = MyParent;
            maBH = strMaBaiHoc;
            try
            {
                BaiHocDTO baihoc = new BaiHocDTO();
                baihoc = BaiHocBUS.LayBaiHocTheoMa(strMaBaiHoc);
                tenCauChuyen = baihoc.Ten.ToString();
                FileHinhAnh = baihoc.FileHinhAnh.ToString();
                labelX4.Text = tenCauChuyen;
                if (FileHinhAnh != "")
                {
                    Bitmap bm = new Bitmap(FileHinhAnh);
                    bm.MakeTransparent(System.Drawing.Color.White);
                    pictureBox1.BackgroundImage = bm;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grpCauHoi.Visible = true;
            try
            {
                FileLuyenTapDTO LuyenTap = new FileLuyenTapDTO();
                LuyenTap = FileLuyenTapBUS.LayFileLuyenTapTheoMa(maBH);
                string FileCauHoi = LuyenTap.FileNoiDung.ToString();
                RichTextBox cauhoi = new RichTextBox();
                if (FileCauHoi != " ")
                {
                    cauhoi.LoadFile(FileCauHoi);
                   rtbCauHoi .Text = cauhoi.Text;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void KeChuyen_Load(object sender, EventArgs e)
        {

        }

        private void picGCDCauTiepTheo_Click(object sender, EventArgs e)
        {
            if (pnlHinhAnh.Expanded == true && pnlCauChuyenTraLoi.Expanded == false)
            {
                lblGCDCauChuyen.Text = "Hình Ảnh";
                pnlHinhAnh.AnimationTime = 100;
                pnlCauChuyenTraLoi.AnimationTime = 1000;
                pnlHinhAnh.Expanded = false;
                pnlCauChuyenTraLoi.Visible = true;
                rtbNoiDung.Visible = true;
                pnlCauChuyenTraLoi.Expanded = true;
                

                BaiHocDTO baihoc = new BaiHocDTO();
                baihoc = BaiHocBUS.LayBaiHocTheoMa(maBH);
                FileNoiDung = baihoc.FileNoiDung.ToString();
                if (FileNoiDung != "")
                {
                    RichTextBox noidung = new RichTextBox();
                    noidung.LoadFile(FileNoiDung);
                    rtbNoiDung.Text = noidung.Text;

                }

            }
            else
            {
                lblGCDCauChuyen.Text = "Câu Chuyện";
                pnlCauChuyenTraLoi.AnimationTime = 100;
                pnlHinhAnh.AnimationTime = 1000;
                pnlCauChuyenTraLoi.Expanded = false;               
                pnlHinhAnh.Expanded = true;
                rtbNoiDung.Visible = false;
            }
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Show();
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
            frmParent.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlCauChuyenTraLoi.Expanded = true;
            try
            {
                FileLuyenTapDTO LuyenTap = new FileLuyenTapDTO();
                LuyenTap = FileLuyenTapBUS.LayFileLuyenTapTheoMa(maBH);
                string FileDapAn = LuyenTap.FileDapAn.ToString();
                RichTextBox dapan = new RichTextBox();
                if (FileDapAn != "")
                {
                    dapan.LoadFile(FileDapAn);
                    rtbNoiDung.Text = dapan.Text;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
