using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using DTO;
using DAO;

namespace BUS
{
    public class BaiHocBUS
    {
        public static List<BaiHocDTO> LayDanhSachBaiHocTheoTuan(string strMaTuan)
        {
            List<BaiHocDTO> KetQua = new List<BaiHocDTO>();
            try
            {
                DataTable DanhSachBai = BaiHocDAO.LayDanhSachBaiTheoTuan(strMaTuan);
                int nRow = DanhSachBai.Rows.Count;
                for (int i = 0; i < nRow; ++i)
                {
                    BaiHocDTO BaiHoc = new BaiHocDTO();
                    BaiHoc.Ma = DanhSachBai.Rows[i]["Ma"].ToString();
                    BaiHoc.MaLoaiMon = DanhSachBai.Rows[i]["MaLoaiMon"].ToString();
                    BaiHoc.MaTuan = DanhSachBai.Rows[i]["MaTuan"].ToString();
                    BaiHoc.Ten = DanhSachBai.Rows[i]["Ten"].ToString();
                    BaiHoc.FileNoiDung = DanhSachBai.Rows[i]["FileNoiDung"].ToString();
                    BaiHoc.FileAmThanh = DanhSachBai.Rows[i]["FileAmThanh"].ToString();
                    BaiHoc.FileHinhAnh = DanhSachBai.Rows[i]["FileHinhAnh"].ToString();
                    KetQua.Add(BaiHoc);
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return KetQua;
        }

        public static BaiHocDTO LayBaiHocTheoMa(string strMaBaiHoc)
        {
            try
            {
                BaiHocDTO KetQua = new BaiHocDTO();
                DataTable BaiHoc = BaiHocDAO.LayBaiHocTheoMa(strMaBaiHoc);
                if (BaiHoc.Rows.Count > 0)
                {
                    KetQua.Ma = BaiHoc.Rows[0]["Ma"].ToString();
                    KetQua.MaLoaiMon = BaiHoc.Rows[0]["MaLoaiMon"].ToString();
                    KetQua.MaTuan = BaiHoc.Rows[0]["MaTuan"].ToString();
                    KetQua.Ten = BaiHoc.Rows[0]["Ten"].ToString();
                    KetQua.FileHinhAnh = BaiHoc.Rows[0]["FileHinhAnh"].ToString();
                    KetQua.FileAmThanh = BaiHoc.Rows[0]["FileAmThanh"].ToString();
                    KetQua.FileNoiDung = BaiHoc.Rows[0]["FileNoiDung"].ToString();
                }
                return KetQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
