using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class TapLamVanDAO
    {
        public static DataTable LayFileTLVTheoMaBaiHoc(string strMaBaiHoc, string loaiFile)
        {
            string strLenhDocDuLieu = "Select * From FileLuyenTap " +
                                   "Where MaBaiHoc = '" + strMaBaiHoc + "'"+" and LoaiFile = '"+loaiFile+"'";
            DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
            return KetQua;
        }
    }
}
