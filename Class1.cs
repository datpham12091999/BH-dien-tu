using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangDienTU
{
   public  class Class1
    {
       
        public bool KiemTraDangKi(string dangnhap, string matkhau)
        {
            int a = dangnhap.Length;
            int b = matkhau.Length;
            int hoa = 0;
            int so = 0;
            int thuong = 0;
            if (a < 8 || b < 8)
            {
                return false;
            }
            for (int i = 0; i < b; i++)
            {
               
                if (matkhau[i] >= 'A' && matkhau[i] <= 'Z')
                    hoa = 1;
                if (matkhau[i] >= '0' && matkhau[i] <= '9')
                    so = 1;
                if (matkhau[i] >= 97 && matkhau[i] <= 122)
                    thuong = 1;
                if (hoa == 1 && so == 1 && thuong == 1)
                {
                    return true;
                }
               
            }
            return false;

        }
    }
}
