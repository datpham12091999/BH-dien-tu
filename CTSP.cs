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
    public partial class CTSP : Form
    {
       
        public CTSP()
        {
            InitializeComponent();
        }
        public int ma = 0;
        public int KT = 0;
        ClassCTSP CTSP1 = new ClassCTSP();

        private void CTSP_Load(object sender, EventArgs e)
        {
           
            ClassMenu MN = new ClassMenu();
            MN.hienthihinhanh(Hinh1, ma);
            MN.HienThiGiavaTenSP(ma, Ten1,Gia1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MN = new Menu();
            
            MN.ShowDialog();
            this.Close();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = CTSP1.timsptrung(Ten1.Text);

            if ( a == 0)
            {
                Cart C = new Cart();
                CTSP1.ThemVaoDSGH(Ten1.Text, int.Parse(Gia1.Text), 1);
                C.ShowDialog();
                this.Close();

            }
            else
            {
                Cart C = new Cart();
                CTSP1.ThemSoLuong(Ten1.Text);
                C.ShowDialog();
                this.Close();


            }



        }

        private void CTSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassMenu MN = new ClassMenu();
            MN.XoatrongGH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart C = new Cart();
            C.ShowDialog();
            this.Close();

        }
    }
}
