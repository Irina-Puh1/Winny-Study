using System;

namespace HomeWorkLesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите Фамилию:  ");
                string last_Name = Console.ReadLine();
                Console.Write("Введите Имя:  ");
                string first_Name = Console.ReadLine();
                Console.Write("Введите Отчество:  ");
                string patronimic_Name = Console.ReadLine();
                Console.WriteLine();
                string full_Name = GetFullName(last_Name, first_Name, patronimic_Name);
                Console.WriteLine($"Вы ввели: {full_Name}");

                Console.WriteLine($"Хотите ввести еще? \n Нажмите любую клавишу для продолжнения. Для завершения-нажмите<Esc> ");
                
            } while (Console.ReadKey().Key!=ConsoleKey.Escape);

                        
        }

        static string GetFullName(string lastName, string firstName, string patronimic)
        {

            string fullName = lastName + ' ' + firstName + ' ' + patronimic;
            return fullName;
        }
    }
}
