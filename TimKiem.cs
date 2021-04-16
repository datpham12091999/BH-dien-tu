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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
       public string TK ;
       
        private void TimKiem_Load(object sender, EventArgs e)
        {
            ClassTimKiem TK1 = new ClassTimKiem();
            TK1.TimKiemSanPham(dataGridView1, TK);
            dataGridView1.ReadOnly = true;
            label2.Visible = false;
            if ( dataGridView1.Rows[0].Cells[0].Value == null)
            {
                dataGridView1.Visible = false;
                label2.Text = " Không có sản phẩm mà bạn tìm kiếm mời bạn tìm lại ";
                label2.Visible = true;
            }
            dataGridView1.Columns[2].Visible = false;

          
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentCell.Selected = true;
                CTSP CT = new CTSP();
                CT.ma = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["MaSP"].Value.ToString());
                this.Hide();
                CT.ShowDialog();
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ClassTimKiem TK2 = new ClassTimKiem();
            TK2.TimKiemSanPham(dataGridView1, textBox1.Text);
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                dataGridView1.Visible = false;
                label2.Text = " Không có sản phẩm mà bạn tìm kiếm mời bạn tìm lại ";
                label2.Visible = true;
            }
            else
            {
                dataGridView1.Visible = true;
                label2.Visible = false;
            }

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
