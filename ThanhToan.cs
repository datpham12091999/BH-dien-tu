using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangDienTU
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        int KTDN = 0;
        ClassGioHang c = new ClassGioHang();
        ClassThanhToan TT = new ClassThanhToan();
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            int ThanhTienSP = 0;
            c.LaySP(dataGridView1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int n = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                int SL = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                ThanhTienSP = ThanhTienSP + (n * SL);
            }
            lbThanhTien.Text = ThanhTienSP.ToString() ;
            label8.Text = " VND";

        }

        private void BtThanhToan_Click(object sender, EventArgs e)
        {
            
            int a = TT.TimKH(txtHoTen.Text, TXTSDT.Text);
            if ( a == 0)
            {
                Random rd = new Random();
                int MaDH = rd.Next(1000000, 9999999);
                DangKy DK = new DangKy();
                DK.ThemKH(txtHoTen.Text, TXTdiachi.Text, TXTEmail.Text, TXTSDT.Text);
                int MaKh = TT.LayMaKH(txtHoTen.Text, TXTSDT.Text);
                TT.ThemDH(MaKh,MaDH.ToString(),int.Parse(lbThanhTien.Text), dataGridView1);
                MessageBox.Show("Thanh Toan Thanh Cong");
                Menu MN = new Menu();
                MN.ShowDialog();
                this.Close();


            }
            else
            {
                //string KiTu= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                //string random = 

                Random rd = new Random();
                int MaDH = rd.Next(1000000, 9999999);
                int MaKh = TT.LayMaKH(txtHoTen.Text, TXTSDT.Text);
                TT.ThemDH(MaKh, MaDH.ToString(), int.Parse(lbThanhTien.Text), dataGridView1);
                MessageBox.Show("Thanh Toan Thanh Cong");
                Menu MN = new Menu();
                MN.ShowDialog();
                this.Close();


            }

        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {

            ClassMenu MN = new ClassMenu();
            MN.XoatrongGH();
        }
    }
}
