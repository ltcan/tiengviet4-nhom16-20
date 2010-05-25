using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhomTuLTVC : Tu
    {
        bool blnDaDuocChon;

        public bool DaDuocChon
        {
            get { return blnDaDuocChon; }
            set { blnDaDuocChon = value; }
        }

        bool blnDaDuocKeo;

        public bool DaDuocKeo
        {
            get { return blnDaDuocKeo; }
            set { blnDaDuocKeo = value; }
        }

        int intViTriTrongDanhSach;

        public int ViTriTrongDanhSach
        {
            get { return intViTriTrongDanhSach; }
            set { intViTriTrongDanhSach = value; }
        }

        public NhomTuLTVC()
        {
            this.blnDaDuocChon = false;
            this.blnDaDuocKeo = false;
            this.TenLoaiTu = "NhomTuLTVC";
            this.ViTri = -1;
        }

    }
}
