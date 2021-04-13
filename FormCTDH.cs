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
        }
    }
}
