using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoptyaevRS.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KoptyaevRS.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Коптяев Р. С. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Коптяев Рустам Сергеевич | АСОиУБ-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число). По заданным g, n и m     *");
            Console.WriteLine("* определить дату предыдущего дня.Заданный год не является високосным     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер года: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Дата предыдущего дня: " + ds.FindDateOfPreviousDay(g, m, n));

            Console.ReadKey();
        }
    }
}
