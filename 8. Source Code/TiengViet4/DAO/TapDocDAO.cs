using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class TapDocDAO
    {
        public static DataTable LayDanhSachBai(string strMaBaiHoc)
        {
            string strCmd = "Select * From FileLuyenTap " +
                    "Where MaBaiHoc = '" + strMaBaiHoc + "' " +
                    "And MaLoaiMon = 1";
            return CoSoDuLieu.LayDuLieu(strCmd);
        }
    }
}
