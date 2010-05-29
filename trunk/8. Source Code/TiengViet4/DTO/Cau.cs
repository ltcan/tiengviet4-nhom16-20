using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Cau : NhomTuLTVC
    {
        int intSoThuTu;

        public int SoThuTu
        {
            get { return intSoThuTu; }
            set { intSoThuTu = value; }
        }

        //int intCauHoi;

        //public int CauHoi
        //{
        //    get { return intCauHoi; }
        //    set { intCauHoi = value; }
        //}


        public Cau()
        {
            //this.TenLoaiTu = "Cau";
            //this.NoiDung = string.Empty;
            this.intSoThuTu = -1;
            //this.intCauHoi = 0;
        }
    }
}
