using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
    class ClassSuaChua
    {
        DAO da ;
        public ClassSuaChua()
        {
            da = new DAO();
        }
        public void ThemLichSua ( string Tensp , string SDT , string diachi , string MoTa , DateTime NgaySua)
        {
            SuaChua SC = new SuaChua();
            SC.TenSPSuaChua = Tensp;
            SC.MoTaTinhTrang = MoTa;
            SC.SDT = SDT;
            SC.Diachi = diachi;
            SC.NgayDatLich = NgaySua;
            da.ThemLichSuaChua(SC);

        }
    }
}
