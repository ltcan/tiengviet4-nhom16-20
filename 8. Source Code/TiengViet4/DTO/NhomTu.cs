using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhomTu:Tu
    {
        public int ViTriChon;
        
        public NhomTu()
        {
            TenLoaiTu = "NhomTu";
            ViTri = -1;
            ViTriChon = -1;
        }

        //Lấy khoảng vị trí trong Text của từ ở vị trí intViTri trong nhom tu.
        public int[] LayKhoangViTriCuaTuTai(int intViTri)
        {
            string []arrstrSplit = NoiDung.Split(',', '/');
            if (intViTri > -1 && intViTri < arrstrSplit.Length)
            {
                int[] KhoangViTri = new int[2];
                KhoangViTri[0] = NoiDung.IndexOf(arrstrSplit[intViTri]) + ViTri;
                KhoangViTri[1] = arrstrSplit[intViTri].Length;
                return KhoangViTri;
            }
            return null;
        }

        public string LayTuDaChon()
        {
            if (ViTriChon < 0 || ViTri < 0)
            {
                return "@khongcotunaoduocchon@";
            }

            string[] arrstrNhomTu = NoiDung.Split(',','/');
            if (ViTriChon >= arrstrNhomTu.Length)
            {
                return "@khongcotunaoduocchon@";
            }

            return arrstrNhomTu[ViTriChon].Trim();
        }

        //Lấy vị trí chọn trước đó và hiện tại
        //thay đổi tình trạng chọn từ nếu từ ở vị trí dấu nhắc.
        public int[] LayViTriChonVaThayDoiTinhTrangChonTuNeuO(int intViTriDauNhac)
        {
            int[] arrintViTriChon = new int[2];
            arrintViTriChon[0] = ViTriChon;

            //Nếu từ không nằm ở vị trí của dấu nhắc.
            arrintViTriChon[1] = -1;
            
            int intViTriTrongNhomTu = intViTriDauNhac - ViTri;
            if (intViTriTrongNhomTu >= 0 && intViTriTrongNhomTu < NoiDung.Length && NoiDung[intViTriTrongNhomTu] != ',')
            {
                string[] arrstrNhomTu = NoiDung.Split(',', '/');
                int intK = -1;
                for (int i = 0; i < arrstrNhomTu.Length; ++i)
                {
                    intK += (arrstrNhomTu[i].Length + 1);
                    if (intViTriTrongNhomTu < intK)
                    {
                        if (ViTriChon == i)
                        {
                            ViTriChon = -1;
                        }
                        else
                        {
                            ViTriChon = i;
                        }
                        arrintViTriChon[1] = i;
                        break;
                    }
                }
            }
            return arrintViTriChon;
        }
    }
}
