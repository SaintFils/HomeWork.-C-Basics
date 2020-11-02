using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    public delegate double Fun(double x);

    class Program
    {

        public static double TempF(double x)
        {
            return x * x - 50 * x + 10;
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
        public static double MyFunc2(double x)
        {
            return x * x;
        }

        public static double FunCos(double x)
        {
            return Math.Cos(x);
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

        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            List<Fun> funs = new List<Fun>
            {
                new Fun(TempF),
                new Fun(MyFunc),
                new Fun(MyFunc2),
                new Fun(FunCos)
            };
            Console.WriteLine($"Выберите функцию:\n 1. x * x - 50 * x + 10\n2. x*x*x\n3. x*x\n4. Cos");
            int temp = Convert.ToInt32(Console.ReadLine());
            SaveFunc("data.bin", funs[temp - 1], -100, 100, 0.5);
            //SaveFunc("data.bin", funs[0], -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
