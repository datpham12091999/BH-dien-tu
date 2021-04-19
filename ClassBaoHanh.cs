using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangDienTU
{
    public class ClassBaoHanh
    {
        DAO da ;
        public ClassBaoHanh()
        {
            da = new DAO();
        }
        public void LichBaoHanh(string Tensp, string SDT, string diachi, string MoTa, DateTime NgayBaoHanh)
        {
             SuaChua SC = new SuaChua();
             SC.TenSPSuaChua = Tensp;
             SC.MoTaTinhTrang = MoTa;
             SC.SDT = SDT;
             SC.Diachi = diachi;
             SC.NgayDatLich = NgayBaoHanh;
             da.ThemLichSuaChua(SC);
            
            

        }
    }
}
