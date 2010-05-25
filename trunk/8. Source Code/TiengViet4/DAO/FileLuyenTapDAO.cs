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
    }
}
