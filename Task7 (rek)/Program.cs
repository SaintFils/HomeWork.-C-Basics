using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7__rek_
{
    class Program
    {
        static void RekTask(int a, int b)
        {
            Console.Write($"{a} ");
            if (a < b) RekTask(a + 1, b);
        }
        
        static int SumTask(int a, int b)
        {
            return (a < b) ? a + SumTask(a + 1, b) : a;
        }

        static void Main(string[] args)
        {
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            RekTask(1, 10);
            Console.WriteLine();

            Console.WriteLine($"{SumTask(1, 10)}");
        }
    }
}
