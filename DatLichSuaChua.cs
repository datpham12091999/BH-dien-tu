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
    public partial class DatLichSuaChua : Form
    {
        public DatLichSuaChua()
        {
            InitializeComponent();
        }
        ClassSuaChua SC = new ClassSuaChua();

        private void DatLichSuaChua_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenSp.Text == "")
            {
                MessageBox.Show(" Ten SP ko duoc de trong");

            }
            else if (TxtMoTa.Text == "")
            {
                MessageBox.Show(" Vui long nhap ten SP");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui long nhap Dia Chi");

            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show(" vui long nhap SDT");
            }
            else
            {
                SC.ThemLichSua(txtTenSp.Text, txtSDT.Text, txtDiaChi.Text, TxtMoTa.Text, dtNgayGio.Value);
                MessageBox.Show("Da Dat Lich Hen Thanh Cong");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();
        }
    }
}
