using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Доброго времени суток.\n Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}! Cегодня: {DateTime.Now}");
        }
    }
}
