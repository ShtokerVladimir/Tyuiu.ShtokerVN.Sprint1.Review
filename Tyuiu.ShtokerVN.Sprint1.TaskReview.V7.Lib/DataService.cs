using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShtokerVN.Sprint1.TaskReview.V7.Lib
{
    public class DataService
    {
        public double TriangleArea(double x, double y)
        {
            var res = ((Math.Cos(x)) / (Math.PI - 2 * Math.Pow(y, x))) + 16 * x * Math.Cos(x * y) - 2;
            return Math.Round(res, 3);
        }
    }
}
