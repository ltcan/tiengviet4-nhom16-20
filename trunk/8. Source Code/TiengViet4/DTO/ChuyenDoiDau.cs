﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuyenDoiDau
    {
        //Danh sách kí tự sau khi chuyển sẽ được kí tự kết quả.
        string DanhSachKyTu;
        //Ký tự sau khi được chuyển.
        char KyTuKetQua;
        public ChuyenDoiDau(string strDanhSachKyTu, char chrKyTuKetQua)
        {
            DanhSachKyTu = strDanhSachKyTu;
            KyTuKetQua = chrKyTuKetQua;
        }
    }
}
