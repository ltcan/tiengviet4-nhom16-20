using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DAO
{
    public class QuanLyFile
    {
        public static string LayNoiDung(string TenFile)
        {
            StreamReader sr = new StreamReader(TenFile);
            string NoiDung = sr.ReadToEnd();
            sr.Close();
            return NoiDung.Trim();
        }
    }
}
