using System;

namespace HomeWorkLesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число");
            int dig = Convert.ToInt32(Console.ReadLine());
            if ((dig % 2) == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число");
            }
        }
    }
}
