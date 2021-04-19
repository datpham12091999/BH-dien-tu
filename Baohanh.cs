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
    public partial class Baohanh : Form
    {
        public Baohanh()
        {
            InitializeComponent();
        }
        ClassBaoHanh SC = new ClassBaoHanh();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenSp.Text == "")
            {
                MessageBox.Show("Nhập tên sản phẩm");

            }
            else if (TxtMoTa.Text == "")
            {
                MessageBox.Show("Nhập tình trạng");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ");

            }
            else if (SDT.Text == "")
            {
                MessageBox.Show("Nhập SĐT");
            }
            else if (SDT.Text.Length < 10 | SDT.Text.Length > 10)
            {
                MessageBox.Show("SĐT phải có 10 số");
            }
            else
            {
                SC.LichBaoHanh(txtTenSp.Text, SDT.Text, txtDiaChi.Text, TxtMoTa.Text, dtNgayGio.Value);
                MessageBox.Show("Đã đặt lịch bảo hành!!!");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();
        }
        private void SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
