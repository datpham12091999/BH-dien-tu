using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
    class ClassTimKiem
    {
        DAO da;
       public ClassTimKiem()
        {
            da = new DAO();
            
        }
       public int SLSPTK ( string Tensp)
        {
            int a = da.TimLK(Tensp);
            return a;
        }
        public int LayMaSP ( string tenSp)
        {
            int a = da.LayMaSP(tenSp);
            return a;
        }
        public int LayMaDH ( string MaDH)
        {
            int Kq = da.KTMDH(MaDH);
            return Kq;
        }
        public string LayMDH(string MaDH)
        {
            string s = da.LayMDH(MaDH);
            return s;

        }
        public int LayTT(string MaDH)
        {
            int s = da.LayThanhTien(MaDH);
            return s;

        }
        public DateTime LayNgay ( string MaDH)
        {
            DateTime D = da.LayNgay(MaDH);
            return D;
        }
    }
}
