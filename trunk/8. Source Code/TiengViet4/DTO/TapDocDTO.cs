using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TapDocDTO
    {
        private string strMaBaiHoc;

        public string MaBaiHoc
        {
            get { return strMaBaiHoc; }
            set { strMaBaiHoc = value; }
        }
        private string strDuongDanFileNoiDung;

        public string DuongDanFileNoiDung
        {
            get { return strDuongDanFileNoiDung; }
            set { strDuongDanFileNoiDung = value; }
        }
        private string strDuongDanFileHinhAnh;

        public string DuongDanFileHinhAnh
        {
            get { return strDuongDanFileHinhAnh; }
            set { strDuongDanFileHinhAnh = value; }
        }
        private string strDuongDanFileCauHoi;

        public string DuongDanFileCauHoi
        {
            get { return strDuongDanFileCauHoi; }
            set { strDuongDanFileCauHoi = value; }
        }
        private string strDuongDanFileDapAn;

        public string DuongDanFileDapAn
        {
            get { return strDuongDanFileDapAn; }
            set { strDuongDanFileDapAn = value; }
        }

        public TapDocDTO()
        {
            DuongDanFileCauHoi = "";
            DuongDanFileDapAn = "";
            DuongDanFileHinhAnh = "";
            DuongDanFileNoiDung = "";
            MaBaiHoc = "";
        }
    }
}
