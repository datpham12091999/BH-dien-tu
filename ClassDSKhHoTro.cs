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
    public partial class ClassDSKhHoTro : Form
    {
        public ClassDSKhHoTro()
        {
            InitializeComponent();
        }
        string TinhTrang;
        int MaPhieuMuon;
        ClassHoTroKH HT = new ClassHoTroKH();
        private void ClassDSKhHoTro_Load(object sender, EventArgs e)
        {

            
            HT.LayDSKH(dataGridView1);
            dataGridView1.Columns["TinhTrang"].Visible = false;
            dataGridView1.Columns["MaPhieuHoTro"].Visible = false;
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[4].Width = (int)(dataGridView1.Width * 0.2);
           
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Visible = false;
                ThongBao.Visible = true;
                button1.Visible = false;
               




            }
            else
            {
                dataGridView1.Visible = true;
                ThongBao.Visible = false;
                button1.Visible = true;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TinhTrang = dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                MaPhieuMuon = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["MaPhieuHoTro"].Value.ToString());



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TinhTrang = dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                MaPhieuMuon = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["MaPhieuHoTro"].Value.ToString());




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HT.ChinhSuaTinhTrang(MaPhieuMuon, "Đã Xử Lý");
            HT.LayDSKH(dataGridView1);
            ClassDSKhHoTro_Load(sender, e);
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
