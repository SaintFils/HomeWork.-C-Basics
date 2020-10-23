using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2__4th_lesson_
{
    static class StaticClass
    {
        /// <summary>
        /// Метод, который создает массив и заполняет его случайными числами
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <param name="min">Нижняя граница чисел (базовое значение 0)</param>
        /// <param name="max">Верхняя граница чисел (базовое значение 10)</param>
        /// <returns>Возвращается массив, заполненный случайными числами</returns>
        static public int[] ArrCreate(int length, int min=0, int max=10)
        {
            int[] arr = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(min, max);                
            }
            return arr;
        }
        /// <summary>
        /// Вывод в консоль числа из массива
        /// </summary>
        /// <param name="arr">Массив</param>
        static public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} "); 
            }
        }

        /// <summary>
        /// Метод, который считает количество пар в массиве, в которых одно число делится на 3 (пара - два подряд идущих элемента массива)
        /// </summary>
        /// <param name="arr">Массив чисел</param>
        /// <returns></returns>
        static public int PairCounter(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    counter++;
                    i++;
                }
            }
            return counter;
        }
        /// <summary>
        /// Метод, который вывод в консоль пары чисел, где одно число делится на 3 (пара - два подряд идущих элемента массива)
        /// </summary>
        /// <param name="arr">Массив чисел</param>
        static public void PairPrint(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    Console.WriteLine($"{arr[i]} | {arr[i + 1]}");
                    i++;
                }
            }
        }
        /// <summary>
        /// метод для удаления пустот при считывании массива из файла
        /// </summary>
        /// <param name="col">массив</param>
        /// <param name="s">объект, который нужно удалить</param>
        /// <returns></returns>
        static public bool Remove(ref string[] col, string s)
        {
            int pos = Array.IndexOf(col, s);

            if (pos == -1) return false;

            for (int i = pos; i < col.Length - 1; i++)
            {
                col[i] = col[i + 1];
            }
            Array.Resize(ref col, col.Length - 1);
            return true;
        }
        /// <summary>
        /// метод, который считывает из файла массив
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        static public int[] ArrayFromFile (string path)
        {
            StreamReader sf = new StreamReader(path);
            string[] temps = sf.ReadLine().Split(' ');
            
            while(Array.IndexOf(temps, String.Empty) != -1)
            {
                Remove(ref temps, String.Empty);
            }

            int[] arr = new int[temps.Length];

            for (int i = 0; i < temps.Length; i++)
            {
                arr[i] = int.Parse(temps[i]);
            }
            return arr;
        }

    }
}
