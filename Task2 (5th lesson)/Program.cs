using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__5th_lesson_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            // а) Вывести только те слова сообщения,  которые содержат не более n букв.
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            // в) Найти самое длинное слово сообщения.
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            // д) ***Создать метод, который производит частотный анализ текста.
            // В качестве параметра в него передается массив слов и текст,
            //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            //Здесь требуется использовать класс Dictionary.
            #region a)
            Console.WriteLine("Введите сообщение:");
            string tempA = Console.ReadLine();
            Console.WriteLine("Введите максимальное число символов:");
            int numA = Convert.ToInt32(Console.ReadLine());
            string[] resultA = Message.PrintN(tempA, numA, ' ');
            foreach (var item in resultA)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            #endregion

            #region b)
            Console.WriteLine("Введите сообщение:");
            string tempB = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            char symB = Convert.ToChar(Console.ReadLine());
            string resultB = Message.LastChar(tempB, symB, ' ');
            Console.WriteLine($"{resultB}"); 
            #endregion

            #region с)
            Console.WriteLine("Введите сообщение:");
            string tempC = Console.ReadLine();
            Console.WriteLine($"{Message.Longest(tempC, ' ')}");
            Console.ReadLine();
            #endregion

            #region d)
            string tempD = "p pp ppp pppp ppppp o oo ooo oooo ooooo i ii iiii iii iiiii";
            Console.WriteLine($"{Message.LongestMessage(tempD, ' ')}");
            #endregion


        }
    }
}
