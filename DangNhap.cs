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
                MessageBox.Show("ten dang nhap hoac mat khau khong duoc de trong");
            }
            else
            {
                int kq = DN.KiemTraDN(txtdangnhap.Text.ToString(), txtmatkhau.Text.ToString());

                if (kq == 1)
                {
                    MessageBox.Show(" dang nhap thanh cong");
                    this.Hide();
                    Menu MN = new Menu();
                    MN.ShowDialog();
                    


                }
                else if (kq == 2)
                {
                    MessageBox.Show(" sai ten dang nhap ");
                }
                else if (kq == 3)
                {
                    MessageBox.Show(" sai mat khau");

                }
                else
                    MessageBox.Show(" sai ten dang nhap va mat khau ");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi DangKy = new DangKi();
            this.Close();
            DangKy.ShowDialog();
            
        }
    }
}

