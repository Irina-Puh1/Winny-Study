using System;

namespace HomeWorkLesson_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифрами минимальную температуру воздуха за прошедшие сутки:");
            float min_temp = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифрами максимальную температуру воздуха за прошедшие сутки:");
            float max_temp = float.Parse(Console.ReadLine());
            float middle_temp = (min_temp + max_temp) / 2;
            Console.WriteLine($"Средняя температура за прошедшие сутки составила: \n {middle_temp} градусов Цельсия");
        }
    }
}
