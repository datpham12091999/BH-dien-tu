using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BanHangDienTU
{
    class ClassGioHang
    {
        DAO da;
        public ClassGioHang()
        {
            da = new DAO();
        }
        public void LaySP ( DataGridView g )
        {
            g.DataSource = da.ThemSPGH();
        }
        public void ChinhSuaSL ( string tensp , int SL)
        {
            da.ChinhSuaSL(tensp, SL);
        }
    }
}
