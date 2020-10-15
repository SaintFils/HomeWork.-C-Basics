using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Давайте рассчитаем ваш индекс массы тела.\nВведите пожалуйста ваш вес:");
            double weight = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите пожалуйста ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double ind = weight / ((height/100) * (height/100));
            double goodWeight = 21.5 * ((height / 100) * (height / 100)); // для рассчета нормального веса взял примерно средний индекс нормы

            Console.WriteLine($"Ваш индекс массы тела равен {ind:F1}.");

            if (ind <= 16) Console.WriteLine($"У вас выраженный дефицит массы тела.\nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно набрать: {goodWeight-weight:F1}кг.");
            else if (ind > 16 & ind < 18.5) Console.WriteLine($"У вас недостаточная (дефицит) масса тела. \nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно набрать: {goodWeight-weight:F1}кг.");
            else if (ind >= 18.5 & ind <= 25) Console.WriteLine("У вас нормальный вес.");
            else if (ind > 25 & ind < 30) Console.WriteLine($"У вас избыточная масса тела (предожирение). \nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно сбросить: {weight - goodWeight:F1}кг.");
            else if (ind >= 30 & ind <= 35) Console.WriteLine($"У вас ожирение. \nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно сбросить: {weight - goodWeight:F1}кг");
            else if (ind > 35 & ind < 40) Console.WriteLine($"У вас резкое ожирение. \nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно сбросить: {weight - goodWeight:F1}кг");
            else if (ind >= 40) Console.WriteLine($"У вас очень резкое ожирение. \nДля вашего роста норма: {goodWeight:F1}кг.\nВам нужно сбросить: {weight - goodWeight:F1}кг");
            
            Console.ReadLine();
        }
    }
}
