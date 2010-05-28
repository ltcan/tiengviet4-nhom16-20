using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class TapDocDAO
    {
        public static DataTable LayDanhSachBaiHoc(string strMaBaiHoc)
        {
            //Tạo kết nối
            OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"CSDL\CSDL.mdb");
            Conn.Open();

            //Chuỗi truy vấn
            string strCmd = "Select * From BaiHoc " +
                    "Where Ma = @MaBaiHoc";

            //Đối tượng truy vấn
            OleDbCommand Command = new OleDbCommand(strCmd, Conn);
            Command.Parameters.Add("@MaBaiHoc", OleDbType.VarChar).Value = strMaBaiHoc;

            //Đối tượng đọc
            OleDbDataReader dr = Command.ExecuteReader();

            //Nạp dữ liệu cho bảng
            DataTable dtTapDoc = new DataTable("TAPDOC");
            dtTapDoc.Load(dr);

            //Đóng kết nối
            Conn.Close();

            return dtTapDoc;
        }

        public static DataTable LayDanhSachFileLuyenTap(string strMaBaiHoc)
        {
            //Tạo kết nối
            OleDbConnection Conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + @"CSDL\CSDL.mdb");
            Conn.Open();

            //Chuỗi truy vấn
            string strCmd = "Select * From FileLuyenTap " +
                    "Where MaBaiHoc = @MaBaiHoc";

            //Đối tượng truy vấn
            OleDbCommand Command = new OleDbCommand(strCmd, Conn);
            Command.Parameters.Add("@MaBaiHoc", OleDbType.VarChar).Value = strMaBaiHoc;

            //Đối tượng đọc
            OleDbDataReader dr = Command.ExecuteReader();

            //Nạp dữ liệu cho bảng
            DataTable dtTapDoc = new DataTable("TAPDOC");
            dtTapDoc.Load(dr);

            //Đóng kết nối
            Conn.Close();

            return dtTapDoc;

        }
    }
}
