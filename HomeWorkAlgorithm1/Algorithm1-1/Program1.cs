using System;

namespace Algorithm1_1
{
    class Program1
    {
        static void Main(string[] args)
        {
        //  тестовый блок   
            int[] enter_n = { -2, 3, 8, 229, 72 };
            string[] result_expected = { "Число должно быть больше 1", "Простое", "Не простое", "Простое", "Не простое" };
            string test_result;
            for (int i = 0; i < enter_n.Length; i++)
            {
                if (enter_n[i] <= 1)
                    test_result = "Число должно быть больше 1";
                else
                    test_result = PrimeOrComposite(enter_n[i]);

                Console.WriteLine($"Число {enter_n[i]} - {test_result}");
                Console.WriteLine($"Ожидаемый результат: {result_expected[i]}");
                if (test_result == result_expected[i])
                    Console.WriteLine("Тест пройден");
                else
                    Console.WriteLine("Тест не пройден. Необходима дополнительная проверка");
            }
        //   окончание тестового блока


            Console.WriteLine("Введите положительное число N больше 1: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1)
            {
                string result = PrimeOrComposite(n);
                Console.WriteLine($"Число {n} - {result}");
            }
            else
                Console.WriteLine("Число должно быть больше 1");
        }
            
        static string PrimeOrComposite(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                    d++;
                i++;
            }

            if (d == 0)
               return "Простое";
            else
               return "Не простое";

        }
    }
}
