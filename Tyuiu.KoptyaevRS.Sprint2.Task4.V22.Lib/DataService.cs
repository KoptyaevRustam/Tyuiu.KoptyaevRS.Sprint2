using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoptyaevRS.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V20
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 3) > (y * 2 - 21) ? (Math.Round(x, 2) + 12 * y - (2 / x)) : ((Math.Pow(x, 2) + Math.Cos(Math.Pow(y, 2)) + 17) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(y, 2)) + 3));
            return Math.Round(z, 3);
        }
    }
}
