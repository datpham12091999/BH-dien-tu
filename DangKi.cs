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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        ClassThanhToan TT = new ClassThanhToan();
        private void DangKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhapWeb DNW;
            DNW = new DangNhapWeb();
            string s = textBox1.Text;
            string a = textBox2.Text;
            textBox1.Text = DNW.ChuanHoa(s);
            textBox2.Text = DNW.ChuanHoa(a);

            Class1 Kiemtra = new Class1();
            DangNhapWeb KT1 = new DangNhapWeb();
            bool KT = Kiemtra.KiemTraDangKi(textBox1.Text, textBox2.Text);
            int KQ = KT1.KiemTraTK(textBox1.Text);
            if ( textBox1.Text != "" && textBox2.Text != ""  && KT == true && SDT.Text != "" && Email.Text != "" && DiaChi.Text != "" && HoTen.Text != "" && KQ == 0 && SDT.Text.Length == 10)
            {
                DangKy Dk = new DangKy();
                DangNhap DN;
                DN = new DangNhap();
                DN.DangNhap1 = textBox1.Text;
                DN.MatKhau = textBox2.Text;
                Dk.ThemKH(HoTen.Text, DiaChi.Text, NgaySinh.Value.Date, Email.Text, SDT.Text);
                DN.MaKhachHang = TT.LayMaKH(HoTen.Text, SDT.Text);
                Dk.DangKyTK(DN);
                MessageBox.Show(" Dang Ky Thanh Cong");
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
            else if (SDT.Text.Length < 10 | SDT.Text.Length > 10 )
            {
                MessageBox.Show("SDT phai la 10 so");

            }
            else if (SDT.Text == "" | Email.Text == "" | DiaChi.Text == "" | HoTen.Text == "" | textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show(" Vui long dien vao tat ca thong tin");
            }
            else if (KT == false)
            {
                MessageBox.Show(" Mat Khau khong hop le phai co 1 chu hoa va 1 chu thuong va 1 chu so va co 8 ki tu tro len ");
            }
            else if ( KQ == 1 )
            {
                MessageBox.Show(" ten TK bi trung moi nhap Ten TK khac");
            }
        }

        private void SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
                e.Handled = true;
           

        }

        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Cart c = new Cart();
            c.ShowDialog();
            this.Close();
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart c = new Cart();
            c.ShowDialog();
            this.Close();
        }
    }
}
