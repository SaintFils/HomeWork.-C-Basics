using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {NumOfDigits()}");
            Console.ReadLine();
        }

        private static int NumOfDigits()
        {
            int s = 0;
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 2 != 0) s += a;
                a = int.Parse(Console.ReadLine());
            }

            return s;
        }
    }
}
