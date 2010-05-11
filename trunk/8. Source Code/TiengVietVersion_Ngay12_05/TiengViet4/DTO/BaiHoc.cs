using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BaiHoc
    {
        private string m_Ma;
        public string Ma
        {
            get { return m_Ma; }
            set { m_Ma = value; }
        }

        private string m_Ten;
        public string Ten
        {
            get { return m_Ten; }
            set { m_Ten = value; }
        }

        private string m_FileNoiDung;
        public string FileNoiDung
        {
            get { return m_FileNoiDung; }
            set { m_FileNoiDung = value; }
        }

        private string m_FileHinhAnh;
        public string FileHinhAnh
        {
            get { return m_FileHinhAnh; }
            set { m_FileHinhAnh = value; }
        }

        private string m_FileAmThanh;
        public string FileAmThanh
        {
            get { return m_FileAmThanh; }
            set { m_FileAmThanh = value; }
        }

        private string m_MaLoaiMon;
        public string MaLoaiMon
        {
            get { return m_MaLoaiMon; }
            set { m_MaLoaiMon = value; }
        }

        private string m_MaTuan;
        public string MaTuan
        {
            get { return m_MaTuan; }
            set { m_MaTuan = value; }
        }
    }
}
