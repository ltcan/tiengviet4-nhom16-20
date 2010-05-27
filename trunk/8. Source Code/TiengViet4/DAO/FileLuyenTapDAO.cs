using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class FileLuyenTapDAO
    {
        public static DataTable LayFileTheoMaBaiHoc(string strMaBaiHoc)
        {
            string strLenhDocDuLieu = "Select *  From FileLuyenTap " +
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'";
            DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
            return KetQua;
        }

        public static DataTable LayFileTheoMaBaiHoc(string strMaBaiHoc, string strMaLoaiMon)
        {
            string strLenhDocDuLieu = "Select *  From FileLuyenTap " +
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'" +
                                   " And MaLoaiMon = '" + strMaLoaiMon + "'";
            DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
            return KetQua;
        }
    }
}
