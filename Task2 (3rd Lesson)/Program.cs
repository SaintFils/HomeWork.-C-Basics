using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__3rd_Lesson_
{
    class Program
    {
        private static int NumOfDigits()
        {
            int s = 0;
            string a = Console.ReadLine();
            while (int.TryParse(a, out int res) && res != 0)
            {
                if (res > 0 && res % 2 != 0) s += res;
                a = Console.ReadLine();
            }

            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {NumOfDigits()}");
            Console.ReadLine();
        }
    }
}
