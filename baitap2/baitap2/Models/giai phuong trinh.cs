using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baitap2.Models
{
    public class giai_phuong_trinh
    {
        public double GiaiPhuongTrinhBacNhat(double a, double b)
        {
            double x;
            x = -b / a;
            return x;
        }
    }
}