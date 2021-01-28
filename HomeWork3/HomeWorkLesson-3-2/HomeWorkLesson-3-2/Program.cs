using System;

namespace HomeWorkLesson_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] telefoneList = new string [5, 2];

            for (int i = 0; i < telefoneList.GetLength(0); i++)
            {
                Console.Write($"Введите имя {i+1} контакта:  ");
                string name = Console.ReadLine();
                telefoneList[i, 0] = name;

                Console.Write($"Введите телефон и через / е-mail (если есть):  ");
                string contactInfo = Console.ReadLine();
                telefoneList[i, 1] = contactInfo;
                Console.WriteLine();

            }

            Console.WriteLine("-----------------------------     \n");
            Console.WriteLine("Ниже приведен список ваших контактов:");

            for (int i = 0; i< telefoneList.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1}: {telefoneList[i,0]}   {telefoneList[i,1]}");
            }
        }
    }
}
