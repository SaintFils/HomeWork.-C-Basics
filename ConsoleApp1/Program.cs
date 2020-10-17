using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    struct ComplexNumber
    {
        public double a;
        public double b;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="r">вещественная часть</param>
        /// <param name="i">мнимая часть</param>
        public ComplexNumber(double r, double i)
        {
            a = r;
            b = i;
        }
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static ComplexNumber Sum(ComplexNumber z1, ComplexNumber z2)
        {
            ComplexNumber temp = new ComplexNumber(z1.a + z2.a, z1.b + z2.b);
           
            return temp;
        }
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static ComplexNumber Sub(ComplexNumber z1, ComplexNumber z2)
        {
            ComplexNumber temp = new ComplexNumber(z1.a - z2.a, z1.b - z2.b);

            return temp;
        }

        public string Print()
        {
            return b < 0? $"{a} - {-b}i" : $"{a} + {b}i";
        }
    }

    class Program
    {
            
        static void Main()
        {
            #region Проверка работы структуры и класса
            //ComplexNumber z1 = new ComplexNumber(r: 1, i: 2);
            //ComplexNumber z2 = new ComplexNumber(i: -5, r: 3);

            //Console.WriteLine(z1.Print());
            //Console.WriteLine(z2.Print());
            //ComplexNumber resultSum = ComplexNumber.Sum(z1, z2);
            //Console.WriteLine(resultSum.Print());
            //ComplexNumber resultSub = ComplexNumber.Sub(z1, z2);
            //Console.WriteLine(resultSub.Print());

            //ComplexClass x1 = new ComplexClass(3, 8);
            //ComplexClass x2 = new ComplexClass(4, 11);

            //Console.WriteLine(x1.Print() + " - комплексное число 1 из класса");
            //Console.WriteLine(x2.Print() + " - комплексное число 2 из класса");
            //ComplexClass resultSubClass = ComplexClass.Sub(x1, x2);
            //Console.WriteLine(resultSubClass.Print() + " - разность комплексных чисел, созданных с помощью класса");
            //ComplexClass resultMultClass = ComplexClass.Mult(x1, x2);
            //Console.WriteLine(resultMultClass.Print() + " - умножение комплексных чисел, созданных с помощью класса");
            //ComplexClass resultSumClass = ComplexClass.Sum(x1, x2);
            //Console.WriteLine(resultSumClass.Print() );

            #endregion

            Console.Write("Введите вещественную часть первого комплексного числа: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественную часть второго комплексного числа: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть второго комплексного числа: ");
            double i2 = Convert.ToDouble(Console.ReadLine());

            ComplexClass number1 = new ComplexClass(r1, i1);
            ComplexClass number2 = new ComplexClass(r2, i2);

            Console.WriteLine($"Получившиеся комплексные числа: {number1.Print()} и {number2.Print()}." +
                $" \nВведите пожалуйста номер действия, которое вы хотите с ними произвести:\n" +
                $"1. Сложение\n" +
                $"2. Вычитание\n" +
                $"3. Умножение");
            int button = Convert.ToInt32(Console.ReadLine());

              switch (button)
            {
                case 1:
                    ComplexClass resultSum = ComplexClass.Sum(number1, number2);
                    Console.WriteLine($"Вы выбрали сложение. Результат:\n{resultSum.Print()}");
                    break;
                case 2:
                    ComplexClass resultSub = ComplexClass.Sub(number1, number2);
                    Console.WriteLine($"Вы выбрали вычитание. Результат:\n{resultSub.Print()}");
                    break;
                case 3 :
                    ComplexClass resultMult = ComplexClass.Mult(number1, number2);
                    Console.WriteLine($"Вы выбрали вычитание. Результат:\n{resultMult.Print()}");
                    break;
                default: Console.WriteLine("Такой команды нет.");
                    break;

            }
        }
    }
}
