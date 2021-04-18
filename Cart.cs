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
       




        private void Cart_Load(object sender, EventArgs e)
        {

            int ThanhTienSP = 0;
            C.LaySP(dataGridView1);
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.5);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.25);
            if ( dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
                Thongbao.Visible = true;
                Thongbao.Text = " Giỏ Hàng Trống mời Khách Hàng quay lại để chọn sản phẩm";
                Btthanhtoan.Visible = false;
                btcapnhat.Visible = false;
                button1.Visible = false;
              
                


            }
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
            if ( N >= 1000 )
            {
                C.ChinhSuaSL(tensp, 1);
                Cart_Load(sender, e);
            }
            else
            {
                C.ChinhSuaSL(tensp, N);
                Cart_Load(sender, e);
            }
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Số_Lượng"].Value.ToString()) == 0)
            {
                MessageBox.Show("Vui long khong duoc nhap so luong bang 0");
                Btthanhtoan.Enabled = false;
                btcapnhat.Enabled = false;

            }
            else
            {
                tensp = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                soluong = dataGridView1.Rows[e.RowIndex].Cells["Số_Lượng"].Value.ToString();
                N = int.Parse(soluong);
                Btthanhtoan.Enabled = true;
                btcapnhat.Enabled = true;


            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan TT = new ThanhToan();
            TT.ShowDialog();
            this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Cart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tensp = dataGridView1.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                soluong = dataGridView1.Rows[e.RowIndex].Cells["Số_Lượng"].Value.ToString();
                N = int.Parse(soluong);



            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( tensp == null)
            {
                MessageBox.Show("moi chon san pham can xoa");
            }
            else
            {
                C.XoaSP(tensp);
                C.LaySP(dataGridView1);
                Cart_Load(sender, e);
            }
          
        }
    }
}
