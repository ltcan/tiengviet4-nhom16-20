using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public enum LoaiCauHoi
    {
        KhongXacDinh = 0,
        TimCau = 1,
        XacDinhThanhPhan = 2,
        TraLoiViet = 3,
        TracNghiem = 4
    }
    public class CauHoi
    {
        int intViTri;

        public int ViTri
        {
            get { return intViTri; }
            set { intViTri = value; }
        }
        LoaiCauHoi lchLoai;

        public LoaiCauHoi Loai
        {
            get { return lchLoai; }
            set { lchLoai = value; }
        }
        int intSoDapAn;

        public int SoDapAn
        {
            get { return intSoDapAn; }
            set { intSoDapAn = value; }
        }

        int intViTriDuLieu;

        public int ViTriDuLieu
        {
            get { return intViTriDuLieu; }
            set { intViTriDuLieu = value; }
        }

        string strNoiDung;

        public string NoiDung
        {
            get { return strNoiDung; }
            set { strNoiDung = value; }
        }


        public CauHoi()
        {
            intViTri = -1;
            lchLoai = LoaiCauHoi.KhongXacDinh;
            intSoDapAn = 1;
            intViTriDuLieu = -1;
            strNoiDung = string.Empty;
        }
    }
}
