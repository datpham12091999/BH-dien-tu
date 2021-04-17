using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BanHangDienTU
{
    class ClassThanhToan
    {
        DAO da;
        public ClassThanhToan()
        {
            da = new DAO();

        }
        public void ThemDH(int MaKH, string MaDH, int thanhtien, DataGridView g , string diachi , string TinhThanh , string QuanHuyen)
        {
            DonHang D = new DonHang();
            D.MaDonHang = MaDH;
            D.MaKhachHang = MaKH;
            D.ThanhTienDonHang = thanhtien;
            D.NgayMuaHang = DateTime.Today;
            D.DiaChiGiaoHang = diachi;
            D.Tinh_ThanhPho = TinhThanh;
            D.Quan_Huyen = QuanHuyen;
            da.ThemDH(D);
            for (int i = 0; i < g.Rows.Count; i++)
            {
                CTDH CT = new CTDH();
                CT.MaDonHang = MaDH;
                string a = (g.Rows[i].Cells[0].Value.ToString());
                int Masp = da.TimMaSanPham(a);
                CT.MaSanPham = Masp;
                CT.Gia = int.Parse(g.Rows[i].Cells[1].Value.ToString());
                CT.SoLuong = int.Parse(g.Rows[i].Cells[2].Value.ToString());
                da.THEMCTDH(CT);
            }


        }
        public int TimKH(string TenKH, string SDT)
        {
            int kq = da.TimKH(TenKH, SDT);
            return kq;
        }
        public int LayMaKH(string TenKH, string SDTKH)
        {
            int kq = da.LayMaKH(TenKH, SDTKH);
            return kq;
        }
        public void LayTinh(ComboBox cb)
        {
            da.LayTinh(cb);
        }
        public void layQuanHuyen (ComboBox cb , string tentinh)
        {
            int a = da.LayMaTinh(tentinh);
            da.LayQuanHuyen(cb, a);
        }
    }
}
