using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Net.Configuration;

namespace Task1__5th_lesson_
{
    public static class CheckLogin
    {
        public static bool CheckSimple(string str)
        {
            if (str.Length <= 10 && str.Length >= 2) return false;
            char[] arr = str.ToCharArray();
            return !char.IsDigit(arr[0]);
        }

        public static bool CheckRegEx(string str)
        {
            string pat = "^[a-zA-Z][a-zA-Z0-9]{1,9}$";
            return new Regex(pat).IsMatch(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
            //Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
            //при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.

            while(true)
            {
                Console.WriteLine("Введите пожалуйста логин: ");
                string login = Console.ReadLine();
    
                if (CheckLogin.CheckRegEx(login))
                {
                    Console.WriteLine("Логин верный");
                } 
                else Console.WriteLine("повторите попытку ввода");             
            }

            Console.ReadLine();

           


        }
    }
}
