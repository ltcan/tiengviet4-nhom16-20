using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class FileAmThanhBUS
    {
        public static List<FileAmThanhDTO> LayFileAmThanhTheoMa(string strMaFileAmThanh)
        {
            List<FileAmThanhDTO> DanhSachFileAmThanh = new List<FileAmThanhDTO>();
            DataTable Table = FileAmThanhDAO.LayFileAmThanhTheoMa(strMaFileAmThanh);
            for (int i = 0; i < Table.Rows.Count; ++i)
            {
                FileAmThanhDTO fatFileAmThanh = new FileAmThanhDTO();
                fatFileAmThanh.Ma = int.Parse(Table.Rows[i]["Ma"].ToString());
                fatFileAmThanh.MaFileAmThanh = Table.Rows[i]["MaFileAmThanh"].ToString();
                fatFileAmThanh.DuongDanFileAmThanh = Table.Rows[i]["DuongDanFileAmThanh"].ToString();
                fatFileAmThanh.Phan = int.Parse(Table.Rows[i]["Phan"].ToString());               
                DanhSachFileAmThanh.Add(fatFileAmThanh);
            }
            return DanhSachFileAmThanh;
        }
    }
}
