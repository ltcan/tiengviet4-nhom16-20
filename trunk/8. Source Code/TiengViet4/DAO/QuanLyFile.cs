﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DAO
{
    public class QuanLyFile
    {
        public static string LayNoiDung(string strTenFile)
        {
            try
            {
                StreamReader sr = new StreamReader(strTenFile);
                string NoiDung = sr.ReadToEnd();
                sr.Close();
                return NoiDung.Trim();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
