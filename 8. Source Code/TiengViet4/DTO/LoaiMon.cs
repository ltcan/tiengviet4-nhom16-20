using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiMon
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
    }
}
