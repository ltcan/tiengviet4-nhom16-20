using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class ChinhTa
    {
        public static DataTable LayDanhSachBai(string strMaBaiHoc)
        {
            string LenhDocDuLieu = "Select * From FileLuyenTap " + 
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'" +
                                   " And MaLoaiMon = '2'";
            return CoSoDuLieu.LayDuLieu(LenhDocDuLieu);
        }
    }
}
