using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoptyaevRS.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            double res = 0;
            switch (n)
            {
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            res = 1 + (m + 1) * Math.Pow(100, -1);
                            break;
                        case 12:
                            n = 1 + 1 / 100;
                            break;
                    }
                    break;
                case 30:
                    switch (m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            res = 1 + (m + 1) * Math.Pow(100, -1);
                            break;
                    }
                    break;
                case 29:
                    switch (m)
                    {
                        case 2:
                            res = 1 + (m + 1) * Math.Pow(100, -1);
                            break;
                    }
                    break;
                default:
                    res = n + 1 + m * Math.Pow(100, -1);
                    break;
            }
            return res;
        }
    }
}
