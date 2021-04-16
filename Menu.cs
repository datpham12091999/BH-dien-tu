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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        ClassMenu MN = new ClassMenu();
        PictureBox[] PB = new PictureBox[10];
        Label[] TenSP;
        Label[] GiaSP;




        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banHangDienTuDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            
            int a = MN.DemSoHinh();
            PB[0] = Hinh1;
            PB[1] = Hinh2;
            PB[2] = Hinh3;
            PB[3] = Hinh4;
            PB[4] = Hinh5;
            PB[5] = Hinh6;
            PB[6] = Hinh7;
            PB[7] = Hinh8;
            PB[8] = Hinh9;
            PB[9] = Hinh10;
            for ( int i = 0; i < PB.Length; i ++ )
            {
                MN.hienthihinhanh(PB[i], i + 1);
            }
             TenSP = new Label[] { Ten1 ,Ten2 , Ten3, Ten4 , Ten5 , Ten6 , Ten7 , Ten8 , Ten9 , Ten10 };
             GiaSP = new Label[] { Gia1, Gia2, Gia3 , Gia4 , Gia5 , Gia6 , Gia7 , Gia8 , Gia9 , Gia10 };
            for ( int i = 0; i < TenSP.Length; i++)
            {
                MN.HienThiGiavaTenSP(i +1 , TenSP[i], GiaSP[i]);
            }




        }

        private void Hinh1_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 1;
            this.Hide();
            CT.ShowDialog();
            this.Close();
           
        }

        private void Hinh2_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 2;
            this.Hide();
            CT.ShowDialog();
            this.Close();
          
        }

        private void Hinh3_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 3;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh4_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 4;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh5_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 5;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh6_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 6;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh7_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 7;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh8_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 8;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh9_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 9;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Hinh10_Click(object sender, EventArgs e)
        {
            CTSP CT = new CTSP();
            CT.ma = 10;
            this.Hide();
            CT.ShowDialog();
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            MN.XoatrongGH();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text =="")
            {
                MessageBox.Show("Vui lòng không để trống thanh tìm kiếm ");
            }
            else
            {
                this.Hide();
                TimKiem f = new TimKiem();
                f.TK = textBox1.Text;
                f.ShowDialog();

            }
           
        }

        private void traCứuĐHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDH TK = new TKDH();
            this.Hide();
            TK.ShowDialog();
        }

        private void đặtLịchSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatLichSuaChua f = new DatLichSuaChua();
            f.ShowDialog();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }

}
    

