using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TuanHocDTO
    {
        private string _maTuan;

        public string MaTuan
        {
            get { return _maTuan; }
            set { _maTuan = value; }
        }

        private string _tenTuan;

        public string TenTuan
        {
            get { return _tenTuan; }
            set { _tenTuan = value; }
        }

        public TuanHocDTO()
        {
            MaTuan = "";
            TenTuan = "";
        }
    }
}
