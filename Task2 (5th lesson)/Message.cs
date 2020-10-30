using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2__5th_lesson_
{
    static class Message
    {
        /// <summary>
        /// Метод для создания массива слов с длинной не более указанной
        /// </summary>
        /// <param name="message">сообщение из которого нужно получить слова</param>
        /// <param name="lengthWord">максимальная длина слова</param>
        /// <param name="separator">разделитель</param>
        /// <returns>Возвращается массив слов</returns>
        static public string[] PrintN (string message, int lengthWord, params char[] separator)
        {
            string[] words = message.Split(separator);
            string[] result = new string[0];
            int counter = 0;

            foreach (var word in words) 
            {
                if(word.Length <= lengthWord)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[counter++] = word;
                }

            }
            return result;
        }
        /// <summary>
        /// Метод удаляет слова которые оканчиваются на конкретный символ
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="sym">символ</param>
        /// <param name="separator">разделитель</param>
        /// <returns>возвращает сообщение со словами, которые не содержат указанный символ</returns>
        static public string LastChar(string message, char sym, params char[] separator)
        {
            string[] words = message.Split(separator);
            string result = String.Empty;
            foreach (var word in words)
            {
                if(word[word.Length - 1] != sym) //не забывать, что индексация идет с нуля и для обращения к последнему символу нужно вычесть 1!!!
                {
                    result += $"{word} ";
                } 
            }
            return result;
        }
        /// <summary>
        /// Метод находит самое длинное слово в сообщении
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <param name="separator">разделитель</param>
        /// <returns>возвращает самое длинное слово</returns>
        static public string Longest(string message, params char[] separator)
        {
            string[] words = message.Split(separator);
            int temp = words[0].Length;
            string result = words[0];
            foreach (var word in words)
            {
                if(word.Length > temp)
                {
                    temp = word.Length;
                    result = word;
                }
            }
            return result;

        }

        static public StringBuilder LongestMessage(string message, params char[] separator)
        {
            string[] words = message.Split(separator);
            int temp = words[0].Length;
            //string result = words[0];
            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                if (word.Length > temp)
                {
                    temp = word.Length;                   
                }
            }
            foreach (var word in words)
            {
                if (word.Length == temp)
                {
                    //result += word + " ";
                    result.Append($"{word} ");
                }
            }
            return result;
        }



    }
}
