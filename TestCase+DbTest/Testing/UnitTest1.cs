using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BanHangDienTU;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDangKiSaiTenDN()
        {
            Class1 cl = new Class1();
            string dn = "baoduy";
            string mk = "Aa123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
        [TestMethod]
        public void TestDangKiDungTenDNSaiMK()
        {
            Class1 cl = new Class1();
            string dn = "Taikhoan23";
            string mk = "123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq, "mat khau sai");
        }
        [TestMethod]
        public void TestDangKiDungTenDNSaiMK2()
        {
            Class1 cl = new Class1();
            string dn = "baoduy123";
            string mk = "aa123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
        [TestMethod]
        public void TestDangKiDungTenDNvaMK()
        {
            Class1 cl = new Class1();
            string dn = "baoduy1243";
            string mk = "A1a234567";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
        [TestMethod]
        public void TestDangKiDungTenDNSaiMK3()
        {
            Class1 cl = new Class1();
            string dn = "thuphuong21";
            string mk = "AV123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq, "mat khau sai");
        }
    
    }
}
