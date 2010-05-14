using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class TuanHocBUS
    {
        public static List<TuanHocDTO> LayDanhSachTuan()
        {
            List<TuanHocDTO> KetQua = new List<TuanHocDTO>();
            try
            {
                DataTable DanhSachTuan = TuanHocDAO.LayDanhSachTuan();
                int nRow = DanhSachTuan.Rows.Count;
                for (int i = 0; i < nRow; i++)
                {
                    TuanHocDTO TuanHoc = new TuanHocDTO();
                    TuanHoc.MaTuan = DanhSachTuan.Rows[i][0].ToString();
                    TuanHoc.TenTuan = DanhSachTuan.Rows[i][1].ToString();
                    KetQua.Add(TuanHoc);
                }
            }
            catch(Exception Ex)
            {
                throw Ex;
            }           

            return KetQua;
        }
    }
}
