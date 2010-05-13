using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using DTO;

namespace BUS
{
    public class ChinhTa
    {
        public static List<FileLuyenTap> LayDanhSachBaiHoc(string strMaBaiHoc)
        {
            List<FileLuyenTap> DanhSachBai = new List<FileLuyenTap>();
            DataTable Table = DAO.ChinhTa.LayDanhSachBai(strMaBaiHoc);
            for (int i = 0; i < Table.Rows.Count; ++i)
            {
                FileLuyenTap Bai = new FileLuyenTap();
                Bai.Ma = Table.Rows[i]["Ma"].ToString();
                Bai.MaBaiHoc = Table.Rows[i]["MaBaiHoc"].ToString();
                Bai.MaLoaiMon = Table.Rows[i]["MaLoaiMon"].ToString();
                Bai.MaTuan = Table.Rows[i]["MaTuan"].ToString();
                Bai.Ten = Table.Rows[i]["Ten"].ToString();
                Bai.FileDapAn = Table.Rows[i]["FileDapAn"].ToString();
                Bai.FileNoiDung = Table.Rows[i]["FileNoiDung"].ToString();
                DanhSachBai.Add(Bai);
            }
            return DanhSachBai;
        }

        public static List<string> LayDapAn(string strTenFileDapAn)
        {
            string strDapAn = QuanLyFile.LayNoiDung(strTenFileDapAn);
            strDapAn = strDapAn.Replace("||", "|");
            return new List<string>(strDapAn.Split('|'));
        }  
    }
}
