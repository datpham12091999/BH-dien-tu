using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;

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
        DataTable dt;
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
       

    }
}
