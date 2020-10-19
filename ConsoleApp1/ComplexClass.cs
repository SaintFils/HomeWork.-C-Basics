using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ComplexClass
    {
        public double a;
        public double b;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="r">вещественная часть</param>
        /// <param name="i">мнимая часть</param>
        public ComplexClass(double r, double i)
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
        public static ComplexClass Sum(ComplexClass z1, ComplexClass z2)
        {
            ComplexClass temp = new ComplexClass(z1.a + z2.a, z1.b + z2.b);

            return temp;
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static ComplexClass Sub(ComplexClass z1, ComplexClass z2)
        {
            ComplexClass temp = new ComplexClass(z1.a - z2.a, z1.b - z2.b);

            return temp;
        }
        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static ComplexClass Mult(ComplexClass z1, ComplexClass z2)
        {
            ComplexClass temp = new ComplexClass(((z1.a * z2.a) - (z1.b * z2.b)), ((z1.b * z2.a) + (z1.a * z2.b)));

            return temp;
        }

        public string Print()
        {
            return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
        }
    }
}
