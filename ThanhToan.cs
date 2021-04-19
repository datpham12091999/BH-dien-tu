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
                dataGridView1.Rows[i].ReadOnly  = true;


                ThanhTienSP = ThanhTienSP + (n * SL);
            }
            lbThanhTien.Text = ThanhTienSP.ToString() ;
            label8.Text = " VND";
            

        }

        private void BtThanhToan_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || TXTdiachi.Text == "" || TXTEmail.Text == "" || TXTSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!!");
            }
            else if (TXTSDT.Text.Length < 10 | TXTSDT.Text.Length > 10)
            {
                MessageBox.Show("SĐT phải có 10 chữ số!!");
            }
            else
            {
                int a = TT.TimKH(txtHoTen.Text, TXTSDT.Text);
                if (a == 0)
                {
                    Random ra = new Random();
                    string KiTu = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string random;
                    int c = ra.Next(0, KiTu.Length); //string.Lenght gets the size of string
                    random = KiTu.ElementAt(c).ToString();
                    Random rd = new Random();
                    int MaRadom = rd.Next(1000000, 9999999);
                    String MaDH = random + MaRadom;
                    DangKy DK = new DangKy();
                    DK.ThemKH(txtHoTen.Text, TXTdiachi.Text, TXTEmail.Text, TXTSDT.Text);
                    int MaKh = TT.LayMaKH(txtHoTen.Text, TXTSDT.Text);
                    TT.ThemDH(MaKh, MaDH, int.Parse(lbThanhTien.Text), dataGridView1);
                    MessageBox.Show("Thanh Toan Thanh Cong" + "Mã Đơn Hàng Của Bạn Là :" + MaDH);
                    Menu MN = new Menu();
                    MN.ShowDialog();
                    this.Close();


                }
                else
                {
                    Random ra = new Random();
                    string KiTu = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string random;
                    int c = ra.Next(0, KiTu.Length); //string.Lenght gets the size of string
                    random = KiTu.ElementAt(c).ToString();

                    Random rd = new Random();
                    int MaRadom = rd.Next(1000000, 9999999);
                    String MaDH = random + MaRadom;
                    int MaKh = TT.LayMaKH(txtHoTen.Text, TXTSDT.Text);
                    TT.ThemDH(MaKh, MaDH, int.Parse(lbThanhTien.Text), dataGridView1);
                    MessageBox.Show("Thanh Toan Thanh Cong" + "Mã Đơn Hàng Của Bạn Là :" + MaDH);
                    Menu MN = new Menu();
                    MN.ShowDialog();
                    this.Close();


                }
            }
        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {

            ClassMenu MN = new ClassMenu();
            MN.XoatrongGH();
        }

        private void TXTSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GioHang c = new GioHang();
            c.ShowDialog();
            this.Close();
        }
        
    }
}
