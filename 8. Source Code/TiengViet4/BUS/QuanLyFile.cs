using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class QuanLyFile
    {
        public static string LayNoiDung(string strTenFile)
        {
            return DAO.QuanLyFile.LayNoiDung(strTenFile);
        }
    }
}
