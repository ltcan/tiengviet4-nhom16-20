using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class FileAmThanhDAO
    {
        public static DataTable LayFileAmThanhTheoMa(string strMaFileAmThanh)
        {
            string strLenhDocDuLieu = "Select *  From FileAmThanh " +
                                  "Where MaFileAmThanh = '" + strMaFileAmThanh + "' Order By Ma";
            DataTable KetQua = CoSoDuLieu.LayDuLieu(strLenhDocDuLieu);
            return KetQua;
        }
    }
}
