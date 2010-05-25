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
        public static int KiemTraKQPhanLoaiTu(string strDapAnNguoiDung, string []strCacDapAn)
        {
            if (strDapAnNguoiDung == String.Empty)
            {
                throw new Exception("Bạn chưa chọn đáp án nào");
            }

            if (strCacDapAn.Length == 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < strCacDapAn.Length; i++)
                {
                    if (string.Compare(strDapAnNguoiDung, strCacDapAn[i], true) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
