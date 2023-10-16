using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoptyaevRS.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n==1)
            {
                switch (m)
                {
                    case 1: return "31.12." + (g-1);
                    case 2: return "31." + (m - 1) + "." + g;
                    case 3: return "28." + (m - 1) + "." + g;
                    case 4: return "31." + (m - 1) + "." + g;
                    case 5: return "30." + (m - 1) + "." + g;
                    case 6: return "31." + (m - 1) + "." + g;
                    case 7: return "30." + (m - 1) + "." + g;
                    case 8: return "31." + (m - 1) + "." + g;
                    case 9: return "31." + (m - 1) + "." + g;
                    case 10: return "30." + (m - 1) + "." + g;
                    case 11: return "31." + (m - 1) + "." + g;
                    case 12: return "30." + (m - 1) + "." + g;
                }
            }
            switch (n)
            {
                case 2: return (n - 1) + "." + m + "." + g;
                case 3: return (n - 1) + "." + m + "." + g;
                case 4: return (n - 1) + "." + m + "." + g;
                case 5: return (n - 1) + "." + m + "." + g;
                case 6: return (n - 1) + "." + m + "." + g;
                case 7: return (n - 1) + "." + m + "." + g;
                case 8: return (n - 1) + "." + m + "." + g;
                case 9: return (n - 1) + "." + m + "." + g;
                case 10: return (n - 1) + "." + m + "." + g;
                case 11: return (n - 1) + "." + m + "." + g;
                case 12: return (n - 1) + "." + m + "." + g;
                case 13: return (n - 1) + "." + m + "." + g;
                case 14: return (n - 1) + "." + m + "." + g;
                case 15: return (n - 1) + "." + m + "." + g;
                case 16: return (n - 1) + "." + m + "." + g;
                case 17: return (n - 1) + "." + m + "." + g;
                case 18: return (n - 1) + "." + m + "." + g;
                case 19: return (n - 1) + "." + m + "." + g;
                case 20: return (n - 1) + "." + m + "." + g;
                case 21: return (n - 1) + "." + m + "." + g;
                case 22: return (n - 1) + "." + m + "." + g;
                case 23: return (n - 1) + "." + m + "." + g;
                case 24: return (n - 1) + "." + m + "." + g;
                case 25: return (n - 1) + "." + m + "." + g;
                case 26: return (n - 1) + "." + m + "." + g;
                case 27: return (n - 1) + "." + m + "." + g;
                case 28: return (n - 1) + "." + m + "." + g;
                case 29: return (n - 1) + "." + m + "." + g;
                case 30: return (n - 1) + "." + m + "." + g;
                case 31: return (n - 1) + "." + m + "." + g;
                default: throw new ArgumentException($"Данные введены некорректно. Вы ввели {n} {m} {g}");
            }
        }
    }
}
