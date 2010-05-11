using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DAO
{
    public class CoSoDuLieu
    {
        public static DataTable LayDuLieu(string strLenhDocDulieu)
        {
            DataTable Table = new DataTable();
            OleDbDataAdapter Adapter = new OleDbDataAdapter(strLenhDocDulieu, @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CSDL\CSDL.mdb");
            Adapter.Fill(Table);
            return Table;
        }
    }
}
