using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTH2.Models
{
    public class GiaiPhuongTrinh
    {
        public double GiaiPhuongTrinhBacNhat( double a, double b )
        {
            double x;
            x = -b / a;
            return x;

        }
    }
}