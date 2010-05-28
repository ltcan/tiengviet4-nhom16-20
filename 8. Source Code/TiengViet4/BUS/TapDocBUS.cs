using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class TapDocBUS
    {
        public TapDocDTO LayNoiDungBaiHoc(string strMaBaiHoc)
        {
            TapDocDTO tapDocDto = new TapDocDTO();
            
            //Lấy dữ liệu từ bản
            DataTable dtNoiDungBaiHoc = new DataTable("NOIDUNGBAIHOC");
            dtNoiDungBaiHoc = TapDocDAO.LayDanhSachBaiHoc(strMaBaiHoc);

            tapDocDto.MaBaiHoc = strMaBaiHoc;
            tapDocDto.DuongDanFileNoiDung = dtNoiDungBaiHoc.Rows[0]["FileNoiDung"].ToString();
            tapDocDto.DuongDanFileHinhAnh = dtNoiDungBaiHoc.Rows[0]["FileHinhAnh"].ToString();

            DataTable dtCauHoi = new DataTable("CAUHOI");
            dtCauHoi = TapDocDAO.LayDanhSachFileLuyenTap(strMaBaiHoc);

            tapDocDto.DuongDanFileDapAn = dtCauHoi.Rows[0]["FileDapAn"].ToString();
            tapDocDto.DuongDanFileCauHoi = dtCauHoi.Rows[0]["FileNoiDung"].ToString();

            return tapDocDto;
        }
    }
}
