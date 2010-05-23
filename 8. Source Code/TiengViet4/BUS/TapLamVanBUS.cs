using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class TapLamVanBUS
    {
        public static DataTable LayDanhSachBai(string strMaBaiHoc, string loaiFile)
        {
            DataTable dtBaiHoc;
            dtBaiHoc = TapLamVanDAO.LayFileTLVTheoMaBaiHoc(strMaBaiHoc,loaiFile);
            return dtBaiHoc;
        }
    }
}
