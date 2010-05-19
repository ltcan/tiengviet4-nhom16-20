using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhoangTrong_LuyenTuVaCau : KhoangTrong
    {
        private int intViTriDuLieu;

        public int ViTriDuLieu
        {
            get { return intViTriDuLieu; }
            set { intViTriDuLieu = value; }
        }

        public KhoangTrong_LuyenTuVaCau()
        {
            intViTriDuLieu = 0;
        }

        public KhoangTrong_LuyenTuVaCau(KhoangTrong_LuyenTuVaCau Source)
        {
            this.ViTri = Source.ViTri;
            this.ViTriDuLieu = Source.ViTriDuLieu;
            this.TenLoaiTu = Source.TenLoaiTu;
        }
    }
}
