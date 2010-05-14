using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class TuanHocDAO
    {
        public static DataTable LayDanhSachTuan()
        {
            try
            {
                String strLenhLayDuLieu = "Select * From Tuan";
                DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhLayDuLieu);
                return KetQua;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
