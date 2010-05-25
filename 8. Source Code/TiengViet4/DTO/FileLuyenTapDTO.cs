using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class FileLuyenTapDTO
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

        private string m_FileDapAn;
        public string FileDapAn
        {
            get { return m_FileDapAn; }
            set { m_FileDapAn = value; }
        }

      
        private string m_MaBaiHoc;
        public string MaBaiHoc
        {
            get { return m_MaBaiHoc; }
            set { m_MaBaiHoc = value; }
        }

        private string m_LoaiFileLuyenTap;

        public string LoaiFileLuyenTap
        {
            get { return m_LoaiFileLuyenTap; }
            set { m_LoaiFileLuyenTap = value; }
        }
    }
}
