using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
        //Написать метод, возвращающий минимальное из трёх чисел.

        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double min = Findmin(a, b, c);

            Console.WriteLine($"Минимальное число {min}");
            Console.ReadLine();

        }

        private static double Findmin(double a, double b, double c)
        {
            double min;
            if (a < b && a < c) min = a;
            else if (b < c) min = b;
            else min = c;
            return min;
        }
    }
}
