using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class FileLuyenTapBUS
    {
        public static List<FileLuyenTapDTO> LayFileTheoMaBaiHoc(string strMaBaiHoc)
        {
            List<FileLuyenTapDTO> DanhSachFileLuyenTap = new List<FileLuyenTapDTO>();
            DataTable Table = FileLuyenTapDAO.LayFileTheoMaBaiHoc(strMaBaiHoc);
            for (int i = 0; i < Table.Rows.Count; ++i)
            {
                FileLuyenTapDTO fltFileLuyenTap = new FileLuyenTapDTO();
                fltFileLuyenTap.Ma = Table.Rows[i]["Ma"].ToString();
                fltFileLuyenTap.MaBaiHoc = Table.Rows[i]["MaBaiHoc"].ToString();
                fltFileLuyenTap.FileDapAn = Table.Rows[i]["FileDapAn"].ToString();
                fltFileLuyenTap.FileNoiDung = Table.Rows[i]["FileNoiDung"].ToString();
                fltFileLuyenTap.LoaiFileLuyenTap = Table.Rows[i]["LoaiFile"].ToString();
                DanhSachFileLuyenTap.Add(fltFileLuyenTap);
            }
            return DanhSachFileLuyenTap;
        }

        public static List<FileLuyenTapDTO> LayFileTheoMaBaiHoc(string strMaBaiHoc, string strLoaiFile)
        {
            List<FileLuyenTapDTO> DanhSachFileLuyenTap = new List<FileLuyenTapDTO>();
            DataTable Table = FileLuyenTapDAO.LayFileTheoMaBaiHoc(strMaBaiHoc, strLoaiFile);
            for (int i = 0; i < Table.Rows.Count; ++i)
            {
                FileLuyenTapDTO fltFileLuyenTap = new FileLuyenTapDTO();
                fltFileLuyenTap.Ma = Table.Rows[i]["Ma"].ToString();
                fltFileLuyenTap.MaBaiHoc = Table.Rows[i]["MaBaiHoc"].ToString();
                fltFileLuyenTap.FileDapAn = Table.Rows[i]["FileDapAn"].ToString();
                fltFileLuyenTap.FileNoiDung = Table.Rows[i]["FileNoiDung"].ToString();
                fltFileLuyenTap.LoaiFileLuyenTap = Table.Rows[i]["LoaiFile"].ToString();
                DanhSachFileLuyenTap.Add(fltFileLuyenTap);
            }
            return DanhSachFileLuyenTap;
        }


        public static List<string> LayDapAn(string strTenFileDapAn)
        {
            string strDapAn = QuanLyFile.LayNoiDung(strTenFileDapAn);
            strDapAn = strDapAn.Replace("||", "|");
            return new List<string>(strDapAn.Split('|'));
        }
        public static FileLuyenTapDTO LayFileLuyenTapTheoMa(string strMaBaiHoc)
        {
            try
            {
            
                FileLuyenTapDTO KetQua = new FileLuyenTapDTO();
                DataTable BaiHoc = FileLuyenTapDAO.LayFileLuyenTapTheoMa(strMaBaiHoc);
                if (BaiHoc.Rows.Count > 0)
                {
                    KetQua.Ma = BaiHoc.Rows[0]["Ma"].ToString();
                    KetQua.MaBaiHoc = BaiHoc.Rows[0]["MaBaiHoc"].ToString();
                    KetQua.LoaiFileLuyenTap = BaiHoc.Rows[0]["LoaiFile"].ToString();
                    KetQua.FileDapAn = BaiHoc.Rows[0]["FileDapAn"].ToString();
                    KetQua.FileNoiDung = BaiHoc.Rows[0]["FileNoiDung"].ToString();
                }
                return KetQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
