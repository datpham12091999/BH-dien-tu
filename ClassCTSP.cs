using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
    class ClassCTSP
    {
        DAO da;
        public ClassCTSP()
        {
            da = new DAO();
            
        }
        public void ThemVaoDSGH ( string tensp , int giasanpham , int soluong)
        {
            DSGH DS = new DSGH();
            DS.TenSP = tensp;
            DS.GiaBan = giasanpham;
            DS.Số_Lượng = soluong;
            da.ThemSPVB(DS);
        }

        public int timsptrung ( string tensp)
        {
            int a = int.Parse(da.TimSPTrung(tensp));
           return a;
        }
        public void ThemSoLuong ( string tensp )
        {
            da.ThemSLsanpham(tensp);
           
        }
    }
}
