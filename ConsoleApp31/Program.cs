using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание сдано на паре

            // 2 задание
            //Console.WriteLine("Введите длину стороны прямоугольника:");
            //string x = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(x))
            //{
            //    Console.WriteLine("Ошибка! Длина стороны не задана.");
            //    return;
            //}
            //x = x.Trim();

            //if (!double.TryParse(x.Replace(".", ","), out double x1) || x1 <= 0)
            //{
            //    Console.WriteLine("Ошибка! Введена некорректная длина стороны.");
            //    return;
            //}

            //Console.WriteLine("Введите ширину стороны прямоугольника:");
            //string y = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(y))
            //{
            //    Console.WriteLine("Ошибка! Ширина стороны не задана.");
            //    return;
            //}

            //y = y.Trim();

            //if (!double.TryParse(y.Replace(".", ","), out double y1) || y1 <= 0)
            //{
            //    Console.WriteLine("Ошибка! Введена некорректная ширина стороны.");
            //    return;
            //}

            //double result = x1 * y1;
            //Console.WriteLine($"Площадь прямоугольника: {result}");




            // 3 задание
            //Console.WriteLine("Введите стороны прямоугольника через пробел:");
            //string str = Console.ReadLine();

            //while (str.Contains("  "))
            //{
            //    str = str.Replace("  ", " ");
            //}

            //string[] side = str.Trim().Split(' ');

            //if (side.Length != 2)
            //{
            //    Console.WriteLine("Ошибка! Введите ровно две стороны прямоугольника.");
            //    return;
            //}

            //if (!double.TryParse(side[0].Replace(".", ","), out double x) || x <= 0 ||
            //    !double.TryParse(side[1].Replace(".", ","), out double y) || y <= 0)
            //{
            //    Console.WriteLine("Ошибка! Введены некорректные значения сторон.");
            //    return;
            //}

            //double result = x * y;
            //Console.WriteLine($"Площадь прямоугольника: {result}");




            // 4 задание
            //Console.WriteLine("Введите строку для проверки:");
            //string str = Console.ReadLine();

            //string str1 = new string(str.Where(c => !char.IsWhiteSpace(c)).ToArray());

            //int x = str1.Length / 2;
            //string a = str1.Substring(0, x);
            //string b = str1.Substring(x);

            //string str2 = new string(b.Reverse().ToArray());

            //if (b.Equals(str2, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("Введенная строка является палиндромом (без учета пробелов).");
            //}
            //else
            //{
            //    Console.WriteLine("Введенная строка не является палиндромом (без учета пробелов).");
            //}




            // 5 задание -
        }
    }
}
