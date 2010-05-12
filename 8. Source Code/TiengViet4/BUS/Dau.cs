using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace BUS
{
    public class Dau
    {
        static List<QuyTacDau> DanhSachQuyTac;
        private static void LayQuiTac()
        {
            if (DanhSachQuyTac != null)
            {
                DanhSachQuyTac = new List<QuyTacDau>();
            }
            else
            {
                DanhSachQuyTac.Clear();
            }

            StreamReader sr = new StreamReader(@"CaiDat\QuyTacDau.dat");
            int i = -1;
            while (!sr.EndOfStream)
            {
                string strDanhSachKyTuDanhDau = sr.ReadLine();
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
        public static char ChuyenDoi(char chrKytu, char chrDau)
        {
            
            return chrKytu;
        }
    }
}
