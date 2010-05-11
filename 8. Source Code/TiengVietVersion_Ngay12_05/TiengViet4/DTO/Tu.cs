using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Tu
    {
        //Vị trí của từ trong văn bản.
        public int ViTri;
        //Nội dung của từ.
        public string NoiDung;
        //Tên của loại từ thể hiện chức năng của từ đó trong văn bản.
        public string TenLoaiTu;
        public Tu()
        {
            TenLoaiTu = "Tu";
        }
    }
}
