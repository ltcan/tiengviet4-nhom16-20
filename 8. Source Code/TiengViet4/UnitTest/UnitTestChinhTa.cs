using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
    
    [TestFixture]
    public class UnitTestChinhTa
    {
        [Test]
        public void LayDapAn()
        {
            List<string> lstDapAn = BUS.FileLuyenTapBUS.LayDapAn("test.txt");
            Assert.AreEqual(lstDapAn[0], "gi");
            Assert.AreEqual(lstDapAn[1], "gi");
            Assert.AreEqual(lstDapAn[2], "r");
            Assert.AreEqual(lstDapAn[3], "Mỗi");
            Assert.AreEqual(lstDapAn[4], "mỏng");
            Assert.AreEqual(lstDapAn[5], "rỡ");
            Assert.AreEqual(lstDapAn[6], "rải");
            Assert.AreEqual(lstDapAn[7], "thoảng");
            Assert.AreEqual(lstDapAn[8], "tản");
        }

        [Test]
        public void ChuyenDoiDau()
        {
            BUS.QuanLyDau qld = new BUS.QuanLyDau("QuyTacDau.dat");
            Assert.AreEqual(qld.ChuyenDoi('a', '1'), 'á');
            Assert.AreEqual(qld.ChuyenDoi('á', '1'), 'a');
            Assert.AreEqual(qld.ChuyenDoi('ă', '1'), 'ắ');
            Assert.AreEqual(qld.ChuyenDoi('a', '2'), 'à');
            Assert.AreEqual(qld.ChuyenDoi('e', '3'), 'ẻ');
        }

        [Test]
        public void LayNoiDungFile()
        {
            string strNoiDung = BUS.QuanLyFile.LayNoiDung("test.txt");
            Assert.AreEqual(strNoiDung, "gi|gi|r||Mỗi|mỏng|rỡ|rải|thoảng|tản");
        }
    }
}
