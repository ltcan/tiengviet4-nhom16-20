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
            OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"CSDL\CSDL.mdb");
            DataTable Table = new DataTable();
            try
            {
                OleDbDataAdapter Adapter = new OleDbDataAdapter(strLenhDocDulieu, Conn);
                Adapter.Fill(Table);
            }
            catch (OleDbException Ex)
            {
                throw Ex;
            }
            finally
            {
                Conn.Close();
            }
            return Table;
        }
    }
}
