using System;

namespace HomeWorkLesson_2_6
{
    class Program
    {  
        [Flags]
        public enum Weekdays
        { 
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота =0b_0100000,
            Воскресенье = 0b_1000000}
        static void Main(string[] args)
        {
            Weekdays ofice1 = Weekdays.Понедельник | Weekdays.Среда | Weekdays.Пятница;
            Weekdays ofice2 = Weekdays.Вторник | Weekdays.Четверг | Weekdays.Суббота;
            Weekdays ofice3 = Weekdays.Понедельник | Weekdays.Вторник | Weekdays.Среда | Weekdays.Четверг | Weekdays.Пятница | Weekdays.Суббота | Weekdays.Воскресенье;

            Console.WriteLine($"Офис 1 работает в следующие дни:\n {ofice1}");
            Console.WriteLine($"Офис 2 работает в следующие дни:\n {ofice2}");
            Console.WriteLine($"Офис 3 работает в следующие дни:\n {ofice3}");

        }
    }
}
