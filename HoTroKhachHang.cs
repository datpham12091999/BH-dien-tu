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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ClassHoTroKH HT = new ClassHoTroKH();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bthotro_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" | txtSDT.Text ==""| cbdv.Text =="" | cbLoiNhan.Text =="")
            {
                MessageBox.Show(" Vui lòng điền tất cả các thông tin");
            }
            else if ( txtSDT.TextLength != 10 )
            {
                MessageBox.Show(" Vui lòng SĐT phải 10 Số");
            }
            else
            {
                HT.ThemPhieuHoTro(txtTen.Text, txtSDT.Text, DateTime.Now.Date, cbdv.Text, cbLoiNhan.Text, "Chưa Xử Lý");
                MessageBox.Show(" Đăng ký thành công ");
                txtTen.Text = "";
                txtSDT.Text = "";
                cbdv.Text = "";
                cbLoiNhan.Text = "";

            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MN = new Menu();
            MN.ShowDialog();
            this.Close();

        }
    }
}
