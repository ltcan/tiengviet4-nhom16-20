using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DTO;
using BUS;

namespace TiengViet4
{
    public partial class TapDocForm : Form
    {
        private TapDocDTO tapDocDto;

        private string[] arrStrNoiDungCauHoi;
        private string[] arrStrNoiDungDapAn;
        int intCauHoiHienTai;
        private bool bDangMoHinhAnh = false;
        
        private Form frmHinhAnh;
        private Form frmParent;

        public TapDocForm(string strMaBaiHoc, Form frmParent)
        {
            InitializeComponent();

            rtbCauHoi.Visible = false;

            TapDocBUS tapDocBus = new TapDocBUS();

            try
            {
                tapDocDto = tapDocBus.LayNoiDungBaiHoc(strMaBaiHoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            NapBaiHoc();
            this.frmParent = frmParent;
            frmParent.Hide();
        }

        private void NapBaiHoc()
        {
            if (tapDocDto.DuongDanFileNoiDung == "")
            {
                return;
            }

            string strNoiDungBaiHoc;
            string strNoiDungTuMoi;

            if (File.Exists(tapDocDto.DuongDanFileNoiDung) == true)
            {
                StreamReader sr = new StreamReader(tapDocDto.DuongDanFileNoiDung);
                strNoiDungBaiHoc = sr.ReadToEnd();
                sr.Close();

                rtbNoiDungBaiHoc.Rtf = strNoiDungBaiHoc;

                int intIndex = rtbNoiDungBaiHoc.Text.IndexOf("\n\n\n") + 1;
                if (intIndex > 0)
                {
                    strNoiDungTuMoi = rtbNoiDungBaiHoc.Text.Substring(intIndex, rtbNoiDungBaiHoc.Text.Length - intIndex);
                    rtbTuMoi.Text = strNoiDungTuMoi.Replace("\n\n\n", "");
                    rtbNoiDungBaiHoc.Select(intIndex, rtbNoiDungBaiHoc.Text.Length - intIndex);
                    rtbNoiDungBaiHoc.Cut();
                }
                else
                {
                    rtbTuMoi.Text = "";
                }
                rtbNoiDungBaiHoc.Select(0, 0);
                //rtbTuMoi.SelectAll();
                rtbTuMoi.Font = new Font("Times New Roman", 12);
            }
            else
            {
                MessageBox.Show("Không tồn tại file cần thiết");
            }
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //Cấu hình các component
            rtbNoiDungBaiHoc.Height -= (rtbCauHoi.Height - 20);
            rtbCauHoi.Visible = true;

            //Thực hiện các thao tác            
            string strErr = "";

            //Kiểm tra lỗi
            if (File.Exists(tapDocDto.DuongDanFileCauHoi) == false)
            {
                strErr = "Không tìm thấy file câu hỏi\n";
            }
            if (File.Exists(tapDocDto.DuongDanFileDapAn) == false)
            {
                strErr += "Không tìm thấy file đáp án";
            }

            if (strErr == "")
            {
                StreamReader sr = new StreamReader(tapDocDto.DuongDanFileCauHoi);
                rtbCauHoi.Rtf = sr.ReadToEnd();
                sr.Close();

                //Đếm số lượng câu hỏi
                int intSoLuongCauHoi = 0;
                for (int i = 0; i < rtbCauHoi.Text.Length; i++)
                {
                    if (rtbCauHoi.Text[i] == '\n')
                    {
                        intSoLuongCauHoi++;
                    }
                }

                //Kiểm tra có thiếu câu hỏi hay không
                if (rtbCauHoi.Text[rtbCauHoi.Text.Length - 1] != '\n')
                {
                    intSoLuongCauHoi++;
                    rtbCauHoi.Text += "\n";
                }

                arrStrNoiDungCauHoi = new string[intSoLuongCauHoi];
                arrStrNoiDungDapAn = new string[intSoLuongCauHoi];

                int j = 0;

                //Lấy nội dung cho từng câu hỏi
                try
                {
                    for (int i = 0; i < intSoLuongCauHoi; i++)
                    {
                        j = rtbCauHoi.Text.IndexOf("\n");
                        arrStrNoiDungCauHoi[i] = rtbCauHoi.Text.Substring(0, j);
                        rtbCauHoi.Text = rtbCauHoi.Text.Replace(arrStrNoiDungCauHoi[i] + "\n", "");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Lấy nội dung cho từng đáp án
                sr = new StreamReader(tapDocDto.DuongDanFileDapAn);
                rtbCauHoi.Rtf = sr.ReadToEnd();
                sr.Close();

                //Thêm ký tự xuống hàng cho đáp án nếu thiếu
                if (rtbCauHoi.Text[rtbCauHoi.Text.Length - 1] != '\n')
                {
                    rtbCauHoi.Text += "\n";
                }
                if (rtbCauHoi.Text[rtbCauHoi.Text.Length - 2] != '\n')
                {
                    rtbCauHoi.Text += "\n";
                }      

                try
                {
                    for (int i = 0; i < intSoLuongCauHoi; i++)
                    {
                        j = rtbCauHoi.Text.IndexOf("\n\n");
                        arrStrNoiDungDapAn[i] = rtbCauHoi.Text.Substring(0, j);
                        rtbCauHoi.Text = rtbCauHoi.Text.Replace(arrStrNoiDungDapAn[i] + "\n\n", "");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                intCauHoiHienTai = 0;
                BatDauTraLoi();
            }
            else
            {
                MessageBox.Show(strErr, "Chào Bé");
            }
        }

        private void BatDauTraLoi()
        {
            picTDKetQua.Visible = true;
            picTDCauTiepTheo.Visible = true;
            picTDCauTruoc.Visible = true;
            btnTraLoiCauHoi.Visible = false;
            btnThanhDieuHuongMatTroi.Visible = false;

            rtbCauHoi.Font = new Font("Times New Roman", 14);

            
            rtbTuMoi.ForeColor = Color.Red;
            NapCauHoi();

        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void picTDKetQua_MouseDown(object sender, MouseEventArgs e)
        {
            picTDKetQua.BackgroundImage = Properties.Resources.ketqua1;
        }

        private void picTDKetQua_MouseUp(object sender, MouseEventArgs e)
        {
            picTDKetQua.BackgroundImage = Properties.Resources.ketqua;
        }

        private void picTDCauTiepTheo_Click(object sender, EventArgs e)
        {
            intCauHoiHienTai = (intCauHoiHienTai + 1) % arrStrNoiDungCauHoi.Length;
            NapCauHoi();

        }

        private void picTDCauTruoc_Click(object sender, EventArgs e)
        {

            if (intCauHoiHienTai == 0)
            {
                intCauHoiHienTai = 3;
            }
            else
            {
                intCauHoiHienTai -= 1;
            }
            NapCauHoi();
        }

        private void NapCauHoi()
        {
            rtbCauHoi.Text = arrStrNoiDungCauHoi[intCauHoiHienTai];
            rtbCauHoi.ForeColor = Color.Blue;
        }

        private void NapCauTraLoi()
        {
            rtbCauHoi.Text = arrStrNoiDungDapAn[intCauHoiHienTai];
            rtbCauHoi.ForeColor = Color.Red;

        }

        private void picTDKetQua_Click(object sender, EventArgs e)
        {
            NapCauTraLoi();
        }

        private void rtbNoiDungBaiHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rtbNoiDungBaiHoc_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }


        private void rtbNoiDungBaiHoc_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbNoiDungBaiHoc.SelectionType == RichTextBoxSelectionTypes.Object && bDangMoHinhAnh == false)
            {                
                if (File.Exists(tapDocDto.DuongDanFileHinhAnh) == true)
                {
                    frmHinhAnh = new Form();
                    frmHinhAnh.Text = "Hinh Anh";
                    frmHinhAnh.Size = new Size(640, 480);
                    frmHinhAnh.BackgroundImage = new Bitmap(tapDocDto.DuongDanFileHinhAnh);
                    frmHinhAnh.BackgroundImageLayout = ImageLayout.Stretch;
                    bDangMoHinhAnh = true;

                    frmHinhAnh.Show();
                    frmHinhAnh.FormClosed += new FormClosedEventHandler(frmHinhAnh_FormClosed);
                }
            }
            else if (bDangMoHinhAnh == true)
            {
                frmHinhAnh.Activate();
            }
        }

        private void frmHinhAnh_FormClosed(object sender, EventArgs e)
        {
            frmHinhAnh.Close();
            
        }

        private void TapDocForm_Load(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "winword";
            proc.StartInfo.Arguments = "huongdan.doc";
            proc.Start();
        }

        private void btnHome_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmParent.Show();
            this.Close();
        }

    }
}