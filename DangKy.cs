using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
    class DangKy
    {
        DAO da;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DangKy()
        {
            da = new DAO();

        }
        public void DangKyTK(DangNhap DK)
        {
            db.DangNhaps.InsertOnSubmit(DK);
            db.SubmitChanges();
        }
        public void ThemKH ( string HoTen , string DiaChi , DateTime  NgaySinh , string Email , string SDT)
        {
            KhachHang Kh = new KhachHang();
            Kh.HoTen = HoTen;
            Kh.NgaySinh = NgaySinh;
            Kh.SDT = SDT;
            Kh.Email = Email;
            Kh.DiaChi = DiaChi;
            da.ThemTTKH(Kh);
        }
        public void ThemKH(string HoTen, string DiaChi,  string Email, string SDT)
        {
            KhachHang Kh = new KhachHang();
            Kh.HoTen = HoTen;
            Kh.SDT = SDT;
            Kh.Email = Email;
            Kh.DiaChi = DiaChi;
            da.ThemTTKH(Kh);

        }

    }
}
