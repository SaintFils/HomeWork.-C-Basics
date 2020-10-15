using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //Гурман Олег, факультет разработки игр, курс "Основы языка C#"
        //Реализовать метод проверки логина и пароля.
        //На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
            #region Решение с for
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Введите пожалуйста ваш логин: ");
            //    string login = Console.ReadLine();
            //    Console.Write("Введите пароль: ");
            //    string pass = Console.ReadLine();


            //    if (Authorization(login,pass))
            //    {
            //        Console.WriteLine("Добро пожаловать");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Попробуйте еще раз");
            //    }
            //}
            #endregion
            int counter = 0;
            do
            {
                Console.Write("Введите пожалуйста ваш логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();

                if (Authorization(login, pass))
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз");
                    counter++;
                }
            } while (counter != 3);

        }

        static bool Authorization (string login, string pass)
        {
           return (login == "root" && pass == "GeekBrains");
         
        }
    }
}
