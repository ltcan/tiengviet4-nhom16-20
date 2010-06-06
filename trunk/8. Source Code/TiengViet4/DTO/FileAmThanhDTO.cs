using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class FileAmThanhDTO
    {
        private int m_Ma;

        public int Ma
        {
            get { return m_Ma; }
            set { m_Ma = value; }
        }
        private string m_MaFileAmThanh;

        public string MaFileAmThanh
        {
            get { return m_MaFileAmThanh; }
            set { m_MaFileAmThanh = value; }
        }
        private string m_DuongDanFileAmThanh;

        public string DuongDanFileAmThanh
        {
            get { return m_DuongDanFileAmThanh; }
            set { m_DuongDanFileAmThanh = value; }
        }
        private int m_Phan;

        public int Phan
        {
            get { return m_Phan; }
            set { m_Phan = value; }
        }
        public FileAmThanhDTO()
        {
            Ma = 0;
            MaFileAmThanh = "";
            DuongDanFileAmThanh = "";
            Phan = 0;
        }
    }
}
