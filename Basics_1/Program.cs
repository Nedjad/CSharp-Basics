using System;

namespace Basics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");

            string name = Console.ReadLine();

            DateTime dt = DateTime.Now;

            Console.WriteLine($"Привет, {name}! Сегодня {dt}");

            
        }
    }
}
