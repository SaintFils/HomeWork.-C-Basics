using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
        //Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            #region Решение из урока
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;

            //while (n != 0)
            //{
            //    count++;
            //    n = n / 10;
            //}
            //Console.WriteLine(count);
            #endregion
            #region Решение с методом с while
            //Console.Write("Введите число, количество цифр которого нужно посчитать: ");
            //long num = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine($"Количество цифр равно {numOfDigitsWhile(num)}");
            //Console.ReadLine();
            #endregion
            #region Решение с методом for
            Console.Write("Введите число, количество цифр которого нужно посчитать: ");
            long num = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"Количество цифр равно {numOfDigitsFor(num)}");
            Console.ReadLine();
            #endregion
        }

        static int numOfDigitsWhile (long n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            return count;
        }

        static int numOfDigitsFor(long n)
        {
            int count = 0;
            for (int i = 1; n != 0; i++)
            {
                n = n / 10;
                count = i;
            }
            return count;
          
        }
    }
}
