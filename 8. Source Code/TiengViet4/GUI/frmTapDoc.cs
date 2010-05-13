using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.IO;


namespace TiengViet4
{
    public partial class frmTapDoc : Form
    {
        public frmTapDoc(string strMaBaiHoc)
        {
            InitializeComponent();
            string strNoiDung = "";
            DataTable dtBaiHoc = TapDoc_Bus.LayDanhSachBai(strMaBaiHoc);
            if (dtBaiHoc.Rows.Count > 0)
            {
                strNoiDung = DocNoiDungFile(dtBaiHoc.Rows[0]["FileNoiDung"].ToString());
                lblNoiDungBaiDoc.Text = strNoiDung;
            }
        }

        private string DocNoiDungFile(string strFileName)
        {
            string strNoiDung = "";
            if (File.Exists(strFileName) == true)
            {
                StreamReader sr = new StreamReader(strFileName);
                strNoiDung = sr.ReadToEnd();
                sr.Close();
            }
            return strNoiDung;
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            btnThanhDieuHuongMatTroi.Visible = false;
            pnlTracNghiem.Expanded = true;
        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        private void btnAmThanh_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            MusicPlayer ms = new MusicPlayer();
            ms.Open("D:\\1.mp3");
            ms.Play(false);
        }
    }
}