using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BanHangDienTU
{
    class ClassMenu
    {
        DAO da;
        public ClassMenu()
        {
            da = new DAO();
        }
        public int DemSoHinh ( )
        {
            int a = da.DemSP();
            return a;
        }
        public void hienthihinhanh ( PictureBox hinh , int MaSP )
        {
            
                SqlConnection con;
                con = new SqlConnection("Data Source=DESKTOP-ROIV26B;Initial Catalog=BanHangDienTu;Integrated Security = true");

                con.Open();
                SqlCommand cmd;
                string s = ("select HinhAnhSP from SanPham where MaSP=" + MaSP);
                cmd = new SqlCommand(s, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)

                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["HinhAnhSP"]);
                    if (hinh.Visible == false)
                    {
                        hinh.Image = new Bitmap(ms);
                        hinh.Visible = true;
                    }
                }
            }
        public void HienThiGiavaTenSP (int ma , Label tensp , Label giaban)
        {
            string TenSP = da.laytenSP(ma);
            string GiaSP = da.LayGiaBanSP(ma);
            tensp.Text = TenSP;
            giaban.Text = GiaSP;
            


        }
        public void XoatrongGH()
        {
            da.XoaTrongGH();
        }


        }
    }
