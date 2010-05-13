using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace BUS
{
    public class QuanLyDau
    {
        List<QuyTacDau> DanhSachQuyTac;
        public QuanLyDau(string strFileQuyTacDau)
        {            
            DanhSachQuyTac = new List<QuyTacDau>();    
            StreamReader sr = new StreamReader(strFileQuyTacDau);
            int i = -1;
            while (!sr.EndOfStream)
            {
                string strDanhSachKyTuDanhDau = sr.ReadLine().Trim();
                string[] arrstrQuyTacChuyen = strDanhSachKyTuDanhDau.Split(' ');
                if (arrstrQuyTacChuyen.Length == 1)
                {
                    QuyTacDau qtdQuyTacMoi = new QuyTacDau(strDanhSachKyTuDanhDau);
                    DanhSachQuyTac.Add(qtdQuyTacMoi);
                    ++i;
                }
                else
                {
                    DanhSachQuyTac[i].ThemQuyTac(arrstrQuyTacChuyen[0], arrstrQuyTacChuyen[1][0]);
                }
            }
            sr.Close();
        }

        public char ChuyenDoi(char chrKytu, char chrDau)
        {
            for (int i = 0; i < DanhSachQuyTac.Count; ++i)
            {
                if (DanhSachQuyTac[i].DanhSachKyTuDanhDau.IndexOf(chrDau) >= 0)
                {
                    for (int j = 0; j < DanhSachQuyTac[i].BangTra.Count; ++j)
                    {
                        if (DanhSachQuyTac[i].BangTra[j].DanhSachKyTu.IndexOf(chrKytu) >= 0)
                        {
                            return DanhSachQuyTac[i].BangTra[j].KyTuKetQua;
                        }
                    }
                }
            }
            return chrKytu;
        }
    }
}
