using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BanHangDienTU;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DangKySaiTenDN()
        {
            ClassKiemTraDangKy cl = new ClassKiemTraDangKy();
            string dn = "Khatuan111112132133212";
            string mk = "Aa123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
        [TestMethod]
        public void DangKySaiMK()
        {
            ClassKiemTraDangKy cl = new ClassKiemTraDangKy();
            string dn = "Khatuan123";
            string mk = "123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq, "mat khau sai");
        }
        [TestMethod]
        public void DangKySaiMK2()
        {
            ClassKiemTraDangKy cl = new ClassKiemTraDangKy();
            string dn = "Khatuan123";
            string mk = "aa123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
        [TestMethod]
        public void DangKySaiMK3()
        {
            ClassKiemTraDangKy cl = new ClassKiemTraDangKy();
            string dn = "Khatuan123";
            string mk = "AV123456";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq, "mat khau sai");
        }
        [TestMethod]
        public void DangKyDung()
        {
            ClassKiemTraDangKy cl = new ClassKiemTraDangKy();
            string dn = "Khatuan123";
            string mk = "Khatuan999";
            bool kq = (cl.KiemTraDangKi(dn, mk));
            Assert.IsTrue(kq);
        }
    }
}