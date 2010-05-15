using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
namespace BUS
{
    public class TapDocBUS
    {
        public static DataTable LayDanhSachBai(string strMaBaiHoc)
        {
            DataTable dtBaiHoc = new DataTable("BAIHOC");
            dtBaiHoc = TapDocDAO.LayDanhSachBai(strMaBaiHoc);
            return dtBaiHoc;
        }
    }
}
