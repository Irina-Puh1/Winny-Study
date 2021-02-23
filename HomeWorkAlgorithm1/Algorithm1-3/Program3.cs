using System;

namespace Algorithm1_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            checking();
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int result = FibonachiNumbersReqursion(n);
            Console.WriteLine($"Результат вычисления с помощью рекурсии: {result}");
            result = FibonachiNumbersCircle(n);
            Console.WriteLine($"Результат вычисления с помощью цикла: {result}");


        }

        static void checking()
        {
            int[] enter_n = { 0, 1, -2, 6, 8, -1, -5, -6 };
            int[] check_result = { 0, 1, -1, 8, 21, 1, 5, -8 };
            for (int i = 0; i < enter_n.Length; i++)
            {
                int result1 = FibonachiNumbersReqursion(enter_n[i]);
                int result2 = FibonachiNumbersCircle(enter_n[i]);
                if (result1 == result2 && result1 == check_result[i])
                {

                    Console.WriteLine($"Число {enter_n[i]}");
                    Console.WriteLine($"Число Фибоначчи: {result1}");
                    Console.WriteLine("Проверка пройдена");

                }
                else if (result1 != result2 && result1 == check_result[i])
                    Console.WriteLine($"Число: {enter_n[i]} - ошибка в методе-цикл");

                else if (result1 != result2 && result2 == check_result[i])
                    Console.WriteLine($"Число: {enter_n[i]} - ошибка в методе-рекурсия");
                else
                    Console.WriteLine($"Число: {enter_n[i]} - Вычисления не верны");
            }

        }


        static int FibonachiNumbersReqursion(int k)
        {
            int summ;
            if (k == 0)
                summ = 0;
            else if (k == 1)
                summ = 1;
            else
            {
                if (k > 0)
                {
                    summ = FibonachiNumbersReqursion(k - 1) + FibonachiNumbersReqursion(k - 2);
                }
                else
                {
                    summ = FibonachiNumbersReqursion(k + 2) - FibonachiNumbersReqursion(k + 1);
                }
            }
            return summ;

        }

        static int FibonachiNumbersCircle(int k)
        {
            int summ = 0;

            if (k == 0)
                summ = 0;
            else if (k == 1 || k == -1)
                summ = 1;
            else
            {
                int summ1 = 0;
                int summ2 = 1;
                if (k < 0)
                {
                    for (int i = 2; i <= k*(-1); i++)
                    {
                        summ = summ1 - summ2;
                        summ1 = summ2;
                        summ2 = summ;
                    }
                }

                else
                {
                    for (int i = 2; i <= k; i++)
                    {
                        summ = summ1 + summ2;
                        summ1 = summ2;
                        summ2 = summ;
                    }
                }

            }

            return summ;

        }


    }
}
