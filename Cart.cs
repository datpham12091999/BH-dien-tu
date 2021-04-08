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
      
       

        private void Cart_Load(object sender, EventArgs e)
        {
            ClassGioHang Cart = new ClassGioHang();
            Cart.LaySP(dataGridView1);
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MN = new Menu();
           
            MN.ShowDialog();
            this.Close();
            
            
        }
        
       
    }
}
