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
    public partial class FormCTDH : Form
    {
        public FormCTDH()
        {
            InitializeComponent();
        }
        public string MaDH = "";

        private void FormCTDH_Load(object sender, EventArgs e)
        {
            ClassTimKiem K = new ClassTimKiem();
            K.LayCTDH(dataGridView1, MaDH);
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.5);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.25);
        }
    }
}
