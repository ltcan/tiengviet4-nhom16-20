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
<<<<<<< .mine
        public static DataTable LayFileLuyenTapTheoMa(string strMaBaiHoc)
        {
            string strLenhDocDuLieu = "Select * From FileLuyenTap " +
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'";

            try
            {
                DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
                return KetQua;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
=======

        public static DataTable LayFileTheoMaBaiHoc(string strMaBaiHoc, string strLoaiFile)
        {
            string strLenhDocDuLieu = "Select *  From FileLuyenTap " +
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'" +
                                   " And LoaiFile = '" + strLoaiFile + "'";
            DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
            return KetQua;
        }
>>>>>>> .r224
    }
}
