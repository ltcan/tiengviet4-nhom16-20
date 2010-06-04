using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class BaiHocDAO
    {
        public static DataTable LayDanhSachBaiTheoTuan(string strMaTuan)
        {
            string strLenhDocDuLieu = "Select * From BaiHoc " + 
                                   "Where MaTuan = '" + strMaTuan + "' Order By Ten";
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

        public static DataTable LayBaiHocTheoMa(string strMaBaiHoc)
        {
            string strLenhDocDuLieu = "Select * From BaiHoc " +
                                   "Where Ma = '" + strMaBaiHoc + "'";

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

    }
}
