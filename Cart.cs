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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            
        }
        string tensp;
        ClassGioHang C = new ClassGioHang();
        string soluong;
        int N;
        string thanhtien;




        private void Cart_Load(object sender, EventArgs e)
        {

            int ThanhTienSP = 0;
            C.LaySP(dataGridView1);
           for ( int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int n =int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                int SL = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                ThanhTienSP = ThanhTienSP + (n * SL);
            }
            TT.Text = ThanhTienSP.ToString() + " VND";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
          
            
           
           
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MN = new Menu();
           
            MN.ShowDialog();
            this.Close();
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tensp = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                 soluong =dataGridView1.Rows[e.RowIndex].Cells["Số_Lượng"].Value.ToString();
                 N = int.Parse(soluong);
                


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.ChinhSuaSL(tensp, N);
            Cart_Load(sender, e);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tensp = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            soluong = dataGridView1.Rows[e.RowIndex].Cells["Số_Lượng"].Value.ToString();
            N = int.Parse(soluong);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan TT = new ThanhToan();
            TT.ShowDialog();
            this.Close();
        }
    }
}
