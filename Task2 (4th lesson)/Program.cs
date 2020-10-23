using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__4th_lesson_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
            //Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            //в)**Добавьте обработку ситуации отсутствия файла на диске.


            int[] arr = StaticClass.ArrCreate(20, -10000, 10001);
            StaticClass.Print(arr);   
            
            Console.WriteLine();

            StaticClass.PairPrint(arr); // вывожу пары для проверки 
            Console.WriteLine($"Количество пар {StaticClass.PairCounter(arr)}");

            Console.ReadLine();

            Console.WriteLine($"{StaticClass.ArrayFromFile("ArrayFile.txt")}");

            Console.ReadLine();

        }
    }
}
