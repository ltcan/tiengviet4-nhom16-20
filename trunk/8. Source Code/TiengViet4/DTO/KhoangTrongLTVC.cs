using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhoangTrongLTVC : KhoangTrong
    {
        private int intViTriDuLieu;

        public int ViTriDuLieu
        {
            get { return intViTriDuLieu; }
            set { intViTriDuLieu = value; }
        }

        public KhoangTrongLTVC()
        {
            intViTriDuLieu = 0;
        }

        public KhoangTrongLTVC(KhoangTrongLTVC Source)
        {
            this.ViTri = Source.ViTri;
            this.ViTriDuLieu = Source.ViTriDuLieu;
            this.TenLoaiTu = Source.TenLoaiTu;
        }
    }
}
