using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BUS;
using System.IO;
using NUnit.Framework;
using DTO;
using TiengViet4;

namespace UnitTest
{
    [TestFixture]
    public class UnitTestLuyenTuVaCauBUS
    {
        [Test]
        [ExpectedException(typeof(System.Exception), ExpectedMessage = "Bạn chưa chọn đáp án nào")]
        public void KiemTraKQPhanLoaiTuTest1()
        {
            string strDapAnNguoiDung = string.Empty;
            string strCacDapAn = string.Empty;

            LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
        }

        [Test]
        public void KiemTraKQPhanLoaiTuTest2()
        {
            string strDapAnNguoiDung = "abc";
            string strCacDapAn = string.Empty;

            bool blnKetQua = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
            Assert.That(blnKetQua, Is.EqualTo(false));
        }

        [Test]
        public void KiemTraKQPhanLoaiTuTest3()
        {
            string strDapAnNguoiDung = "abc";
            string strCacDapAn = "123, 456";

            bool blnKetQua = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
            Assert.That(blnKetQua, Is.EqualTo(false));
        }

        [Test]
        public void KiemTraKQPhanLoaiTuTest4()
        {
            string strDapAnNguoiDung = "abc";
            string strCacDapAn = "abc, 123, 456";

            bool blnKetQua = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
            Assert.That(blnKetQua, Is.EqualTo(true));
        }

        [Test]
        public void KiemTraKQPhanLoaiTuTest5()
        {
            string strDapAnNguoiDung = "abc";
            string strCacDapAn = "123, abc, 456";

            bool blnKetQua = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
            Assert.That(blnKetQua, Is.EqualTo(true));
        }

        [Test]
        public void KiemTraKQPhanLoaiTuTest6()
        {
            string strDapAnNguoiDung = "abc";
            string strCacDapAn = "123, 456, abc";

            bool blnKetQua = LuyenTuVaCauBUS.KiemTraKQPhanLoaiTu(strDapAnNguoiDung, strCacDapAn);
            Assert.That(blnKetQua, Is.EqualTo(true));
        }
    }

    [TestFixture]
    public class UnitTestLuyenTuVaCauGUI
    {
        //[Test]
        //public void TestDocDe1()
        //{
        //    KhungLamBaiLuyenTuVaCau klbLuyenTuVaCau = new KhungLamBaiLuyenTuVaCau();
        //    klbLuyenTuVaCau.DocDe("19-1-1.rtf", 10);

        //    //Contains.
        //}
    }
}
