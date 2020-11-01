using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate double Fun(double x);
    public delegate double Fun2(double x, double a);

    class Program
    {
         /// <summary>
         /// Метод который строит таблицу функции
         /// </summary>
         /// <param name="F">функция</param>
         /// <param name="x">переменная 1</param>
         /// <param name="b">переменная 2</param>
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        /// <summary>
        /// Метод, который строит таблицу функции с двумя переменными
        /// </summary>
        /// <param name="F">функция</param>
        /// <param name="a">переменная 1</param>
        /// <param name="b">переменная 2</param>
        /// <param name="x">переменная 3</param>
        public static void Table(Fun2 F, double a, double b, double x)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (a <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, F(x,a));
                a += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// метод который возводит число в квадрат
        /// </summary>
        /// <param name="x">число</param>
        /// <returns>результат возведения в третью степень</returns>
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        /// <summary>
        /// метод который умножает число на квадрат другого числа
        /// </summary>
        /// <param name="a">число 1</param>
        /// <param name="x">число 2</param>
        /// <returns>результат умножения</returns>
        public static double FunA(double a, double x)
        {
            return a * (x * x);
        }
        /// <summary>
        /// метод который умножает число на синус другого числа
        /// </summary>
        /// <param name="a">число 1</param>
        /// <param name="x">число 2</param>
        /// <returns>результат умножения</returns>
        public static double FunSin(double a, double x)
        {
            return a * Math.Sin(x);
        }


        static void Main(string[] args)
        {
            //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
            //Изменить программу вывода таблицы функции так,
            //чтобы можно было передавать функции типа double(double, double).
            //Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией a* sin(x).

            Console.WriteLine("Таблица функции MyFunc:");            
            Table(new Fun(MyFunc), -2, 2);

            Console.WriteLine("Таблица функции FunA:");
            Table(FunA, -2, 2, 5);

            Console.WriteLine("Таблица функции FunSin:");
            Table(FunSin, -2, 2, 5);

           

        }
    }
}
