using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Windows.Forms;
namespace BanHangDienTU
{
    class DAO
    {
        public DAO()
        {
            conString = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            sqlConn = new SqlConnection(conString);
        }
        SqlConnection sqlConn;
        String conString = "";
        DataClasses1DataContext db = new DataClasses1DataContext();
       
        public void themDN(DangNhap DN)
        {
            db.DangNhaps.InsertOnSubmit(DN);
            db.SubmitChanges();
        }
        public int DangNhap(string dn, string mk)
        {
            int kq = db.KTDangNhap(dn, mk);
            return kq;

        }
        public dynamic getSP ( )
        {
            var Sp = db.SanPhams.Select(s => new
            {
                s.TenSP,
                s.HinhAnhSP
            });
            return Sp;


        }
        public int DemSP ()
        {
            int k = db.DemSoSP();
            return k;
        }
        public string laytenSP(int ma)
        {
           
            string sp =db.TimTenSP(ma);

            return sp;
        }
        public string LayGiaBanSP ( int ma )
        {
           
            string s = db.TimGiaBan(ma).ToString();
            return s;
            
        }
        public  void ThemTTKH ( KhachHang KH)
        {
            db.KhachHangs.InsertOnSubmit(KH);
            db.SubmitChanges();
        }
        public dynamic ThemSPGH ()
        {
            var p = db.DSGHs.Select(s => s).ToList();
           
            return p;

        }
        public void ThemSPVB (DSGH DS)
        {
            db.DSGHs.InsertOnSubmit(DS);
            db.SubmitChanges();

        }
        public void XoaTrongGH ()
        {
            db.DSGHs.DeleteAllOnSubmit(db.DSGHs);
            db.SubmitChanges();
        }
        public string TimSPTrung(string tensp)
        {
           string a = db.TimSPtrung(tensp).ToString();
            return a;

        }
        public void ThemSLsanpham ( string tensp )
        {
            DSGH dh = db.DSGHs.FirstOrDefault(s => s.TenSP.Equals(tensp));
            dh.Số_Lượng = (dh.Số_Lượng + 1);
            db.SubmitChanges();
        }
        public void ChinhSuaSL (string tensp ,int SL)
        {
            DSGH dh = db.DSGHs.FirstOrDefault(s => s.TenSP.Equals(tensp));
            dh.Số_Lượng = SL;
            db.SubmitChanges();
        }
        public void ThemDH ( DonHang DH)
        {
            db.DonHangs.InsertOnSubmit(DH);
            db.SubmitChanges();
        }
        public void THEMCTDH (CTDH CT )
        {
            db.CTDHs.InsertOnSubmit(CT);
            db.SubmitChanges();
        }
        public int TimMaSanPham (string tensp)
        {
            int a = db.TimMaSP(tensp);
            return a;
        }
        public int TimKH ( string HoTen ,string sdt)
        {
            int a = db.TimKH(HoTen, sdt);
            return a;
        }
        public int LayMaKH ( string Hoten , string SDT )
        {
            int kq = db.LayMaKhachHang(Hoten, SDT);
            return kq;
        }
        public int TimLK ( string Tensp)
        {
            int a = db.TimLinhKien(Tensp);
            return a;
        }
        public int LayMaSP ( string tensp)
        {
            int a = db.LayMaSanPham(tensp);
            return a;
            
        }
        public int KTMDH (string MaDH)
        {
            int a = db.TimMaDH(MaDH);
            return a;           
        }
        public int LayThanhTien ( string MaDH )
        {
            int s = db.LayThanhTien(MaDH);
            return s;
        }
        public string LayMDH ( string MaDH)
        {
            string s = db.LayMaDH(MaDH);
            return s;

        }
        public DateTime LayNgay ( string MaDH)
        {
            DateTime D =DateTime.Parse(db.LayNgayDatHang(MaDH).ToString());
            return D;
        }
        public dynamic LayCTDH(string MaDH)
        {

            var CTPM = db.CTDHs.Where(s => s.MaDonHang.Equals(MaDH)).Select(p => new
            {
                p.SanPham.TenSP,
                p.SoLuong,
                p.Gia
                

            }) ;
            return CTPM;

        }
        public void ThemLichSuaChua (SuaChua SC )
        {
            db.SuaChuas.InsertOnSubmit(SC);
            db.SubmitChanges();
        }
        public  int TimTKTRUNG (string TenTK)
        {
            int kq = db.TimTaiKhoan(TenTK);
            return kq;
        }
        public void TimKiemSP (DataGridView g , string TenSP)
        {
            g.DataSource = db.TimKiemSanPham(TenSP);


        }
        public int LaySLSP ( int MaSP)
        {
            int a = db.LaySoLuongSP(MaSP);
            return a;
        }
        public void XoaSPGH ( string tensp )
        {

            DSGH e = db.DSGHs.FirstOrDefault(p => p.TenSP.Equals(tensp));
            db.DSGHs.DeleteOnSubmit(e);
            db.SubmitChanges();
        }
        public void LayTinh(ComboBox cb)
        {
            

            var p = db.Tinhs.Select(s =>
                    new { Name = s.TenTinh,
                    }
                    ).ToList();

            cb.DataSource = p;
            cb.DisplayMember = "Name";
        }
        public int LayMaTinh ( string tentinh)
        {
            int a = db.LayMaTinh(tentinh);
            return a;
            
        }
        public void LayQuanHuyen(ComboBox cb , int matinh)
        {

            var p = db.QuanHuyens.Where(s => s.MaTinh.Equals(matinh)).Select(x => new { 
            Name = x.TenQuanHuyen}).ToList();
            cb.DataSource = p;
            cb.DisplayMember = "Name";
        }
        public int TimMaDHtrung ( string MaDH)
        {
          int kq =  db.TimMaDHTrung(MaDH);
            return kq;
        }
        public void THEMYCHOTRo( HoTroKhachHang HT)
        {
            db.HoTroKhachHangs.InsertOnSubmit(HT);
            db.SubmitChanges();
        }
        public string LayDiaChi(string MaDH)
        {
            string s = db.LayDiaChi(MaDH);
            return s;

        }
        public string LayTinhThanh(string MaDH)
        {
            string s = db.LayTinh(MaDH);
            return s;

        }
        public string LayQuanHuyen(string MaDH)
        {
            string s = db.LayQuanHuyen(MaDH);
            return s;

        }
        public int DangNhapNV(string dn, string mk)
        {
            int kq = db.KTDangNhapNV(dn, mk);
            return kq;

        }
        public dynamic LayDSKHHT ()
        {
            var DSHT = db.HoTroKhachHangs.Where(s => s.TinhTrang.Equals("Chưa Xử Lý")).Select(p => new
            {
                p.MaPhieuHoTro,
                p.HoTenKH,
                p.NgayGio,
                p.SĐT,
                p.DichVu,
                p.LoiNhan,
                p.TinhTrang,
              


            });
            
            return DSHT;
        }
        public void ChinhSuaTinhTrang ( int ma , string TinhTrang)
        {
            HoTroKhachHang HT = db.HoTroKhachHangs.FirstOrDefault(s => s.MaPhieuHoTro.Equals(ma));
            HT.TinhTrang = TinhTrang;
            db.SubmitChanges();
            
        }

    }
}
