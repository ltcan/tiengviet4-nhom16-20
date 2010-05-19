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
        List<FileLuyenTapDTO> DanhSachDeBai;
        int iDeBaiHienTai;
        string strDapAn;
        
        ChonBaiHocForm frmParent;

        public LuyenTuVaCauForm(string strMaBaiHoc, ChonBaiHocForm MyParent)
        {
            InitializeComponent();

            try
            {
                DanhSachDeBai = FileLuyenTapBUS.LayFileTheoMaBaiHoc(strMaBaiHoc);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            iDeBaiHienTai = 0;
            frmParent = MyParent;
        }

        private void btnThoat_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Close();
        }

        private void LuyenTuVaCau_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            frmParent.Hide();
        }

        private void HienThiBaiHoc(bool blnLaBaiHoc3Phan)
        {
            if (blnLaBaiHoc3Phan == true)
            {
                //klbLuyenTuVaCau.DocDe(DanhSachDeBai[0].FileNoiDung, DanhSachDeBai[0].LoaiFileLuyenTap);
            }
        }

        private void picCTKetQua_Click(object sender, EventArgs e)
        {
            if (DanhSachDeBai.Count > 0)
            {
                strDapAn = QuanLyFile.LayNoiDung(DanhSachDeBai[iDeBaiHienTai].FileDapAn);
                
            }
        }
    }
}
