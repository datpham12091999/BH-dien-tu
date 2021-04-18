using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
    class DangNhapWeb
    {
        DAO da;
        public DangNhapWeb()
        {
            da = new DAO();
        }
        public int KiemTraDN(string dangnhap, string matkhau)
        {
            int kq = da.DangNhap(dangnhap, matkhau);
            return kq;
        }
        public string ChuanHoa(string s)
        {
            string chuanhoa = s;
            string x = chuanhoa.Trim();
            return x;
        }
        public int KiemTraTK(string TenTk)
        {
            int a = da.TimTKTRUNG(TenTk);
            return a;


        }
        public int DangNhapNV(string dn, string mk)
        {
            int kq = da.DangNhapNV(dn, mk);
            return kq;

        }
    }
   
}
