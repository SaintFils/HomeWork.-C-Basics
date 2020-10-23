using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1__4th_lesson_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
            //Дан  целочисленный  массив  из 20 элементов.
            //Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
            //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива,
            //в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
            Random rnd = new Random();

            int length = 20;
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(-10000, 10001);
                Console.Write($"{arr[i]}  ");
            }

            Console.WriteLine();

            int counter = 0;
            for (int i = 0; i < length-1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    counter++;
                    Console.WriteLine($"{arr[i]} | {arr[i + 1]}");
                    i++;
                }                
            }

            Console.WriteLine($"Количество пар: {counter}");
            Console.ReadLine();
        }
    }
}
