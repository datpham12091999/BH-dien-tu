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
    public partial class TKDH : Form
    {
        public TKDH()
        {
            InitializeComponent();
        }
        ClassTimKiem DH= new ClassTimKiem();

        private void TKDH_Load(object sender, EventArgs e)
        {
          lbDC.Visible =LbQuanhuyen.Visible =LbTinhThanh.Visible =  lb1.Visible = lb2.Visible = lb3.Visible = lbMaDH.Visible = lbNgayDH.Visible = lbThanhTien.Visible = false;
            button1.Visible = false;
            lbNgayDH.Enabled = false;
        }

        private void TK_Click(object sender, EventArgs e)
        {
           
            if ( textBox1.Text =="")
            {
                MessageBox.Show("Vui lòng không để trống Mã ĐH");
            }
            
            else
            {
                int a = DH.LayMaDH(textBox1.Text);
                if ( a == 0)
                {
                    MessageBox.Show(" Không có ĐH mà bạn tìm kiếm");

                }
                else
                {
                    lbMaDH.Text = DH.LayMDH(textBox1.Text);
                    lbNgayDH.Value = DH.LayNgay(textBox1.Text);
                    lbThanhTien.Text = DH.LayTT(textBox1.Text).ToString();
                    lbDC.Text = DH.LayDiaChi(textBox1.Text);
                    LbTinhThanh.Text = DH.LayTinhThanh(textBox1.Text);
                    LbQuanhuyen.Text = DH.LayQuanHuyen(textBox1.Text);
                    lbDC.Visible = LbQuanhuyen.Visible = LbTinhThanh.Visible = lb1.Visible = lb2.Visible = lb3.Visible = lbMaDH.Visible = lbNgayDH.Visible = lbThanhTien.Visible = true;
                    button1.Visible = true;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCTDH ct = new FormCTDH() ;
            ct.MaDH = textBox1.Text;
            ct.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MN = new Menu();
            MN.ShowDialog();
            this.Close();

        }
    }
}
