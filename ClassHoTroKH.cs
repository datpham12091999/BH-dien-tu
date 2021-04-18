using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangDienTU
{
    class ClassHoTroKH
    {
        DAO da;
        public ClassHoTroKH()
        {
            da = new DAO();
        }
        public void ThemPhieuHoTro(string HoTen, string SDT, DateTime ngaygio, string dichvu, string loinhan, string tinhtrang)
        {
            HoTroKhachHang HT = new HoTroKhachHang();
            HT.HoTenKH = HoTen;
            HT.SĐT = SDT;
            HT.NgayGio = ngaygio;
            HT.DichVu = dichvu;
            HT.LoiNhan = loinhan;
            HT.TinhTrang = tinhtrang;
            da.THEMYCHOTRo(HT);
        }
        public void  LayDSKH(DataGridView g)
        {
            g.DataSource = da.LayDSKHHT();
        }
        public void ChinhSuaTinhTrang ( int ma ,string tinhtrang)
        {
            da.ChinhSuaTinhTrang(ma, tinhtrang);
        }
          


        
    }
}
