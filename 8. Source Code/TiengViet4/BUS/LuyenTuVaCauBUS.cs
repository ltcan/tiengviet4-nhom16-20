using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class LuyenTuVaCauBUS
    {
        // Ham chuan hoa chuoi
        // Nhan vao mot chuoi, tra ra chuoi da chuan hoa
        public static string ChuanHoaChuoi(string strChuoiDauVao)
        {
            string strKetQua = String.Empty;

            return strKetQua;
        }

        // Kiểm tra kết quả phân loại từ
        // Người dùng có thể để lộn xộn đáp án so với file kết quả
        // nên phải tìm kiếm kết quả
        public static bool KiemTraKQPhanLoaiTu(String strDapAnNguoiDung, String strCacDapAn)
        {
            if (strDapAnNguoiDung == String.Empty)
            {
                throw new Exception("Bạn chưa chọn đáp án nào");
            }

            if (strCacDapAn.Length == 0)
            {
                return false;
            }
            else
            {
                int iIndex = strCacDapAn.IndexOf(strDapAnNguoiDung);
                if (iIndex == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
