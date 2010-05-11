using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class QuyTacDau
    {
        //Ký tự dùng để đánh dấu: ví dụ: kí tự đánh dấu 1 thì a1 = á; o1 = ó.
        string DanhSachKyTuDanhDau;
        //Danh sách qui tắc chuyển đổi dấu:
        List<ChuyenDoiDau> DanhSachKyTu;
        public QuyTacDau(string strDanhSachKyTuDanhDau)
        {
            DanhSachKyTuDanhDau = strDanhSachKyTuDanhDau;
            DanhSachKyTu = new List<ChuyenDoiDau>();
        }

        public void ThemQuyTac(string strDanhSachKyTu, char chrKyTuKetQua)
        {
            ChuyenDoiDau cddMoi = new ChuyenDoiDau(strDanhSachKyTu, chrKyTuKetQua);
            DanhSachKyTu.Add(cddMoi);
        }
    }
}
