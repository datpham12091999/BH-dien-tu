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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            DangNhapWeb DN;
            DN = new DangNhapWeb();
            string s = txtdangnhap.Text;
            string a = txtmatkhau.Text;
            txtdangnhap.Text = DN.ChuanHoa(s);
            txtmatkhau.Text = DN.ChuanHoa(a);

            if (txtdangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được trống !!");
            }
            else
            {
                int kq = DN.KiemTraDN(txtdangnhap.Text.ToString(), txtmatkhau.Text.ToString());

                if (kq == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!!");
                    this.Hide();
                    Menu MN = new Menu();
                    MN.ShowDialog();
                    


                }
                else if (kq == 2)
                {
                    MessageBox.Show("Sai tên đăng nhập!!");
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Sai mật khẩu!!");

                }
                else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!");
            }


        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.MaxLength = 15;
        }

        private void BTDANGKY_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi f = new DangKi();
            f.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
        }
    }
}

