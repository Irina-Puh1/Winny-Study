using System;

namespace HomeWorkLesson_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления числа Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());
            int result = FindFibonachi(n);
            Console.WriteLine();
            Console.WriteLine($"Число Фибоначчи {result}");
        }

        static int FindFibonachi(int k)
        {
            int summ;
            if (k == 0)
                summ = 0;
            else if (k == 1 || k == -1)
                summ = 1;
            else
            {
                if (k > 0)
                    summ = FindFibonachi(k - 1) + FindFibonachi(k - 2);
                else
                    summ = FindFibonachi(k + 2) - FindFibonachi(k + 1);
            }
            return summ;
        }
    }
}
