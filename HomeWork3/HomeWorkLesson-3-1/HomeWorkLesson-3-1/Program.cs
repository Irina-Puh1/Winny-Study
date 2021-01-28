using System;

namespace HomeWorkLesson_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] massiv = new int[10,10];
            int i;
            int j;
            for (i = 0; i < massiv.GetLength(0); i++)
            {
                for (j =0; j< massiv.GetLength(1); j++)
                {
                    massiv[i, j] = rand.Next(10, 99);
                    Console.Write($"{massiv[i, j]}  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------\n");

            for (i = 0; i< massiv.GetLength(0); i++) 
            {
                Console.Write($"{massiv[i, i]}  ");
            }
            Console.WriteLine(); 
            Console.WriteLine("------------------------------------------\n");

            j = massiv.GetLength(1) - 1;
            for (i =0; i<massiv.GetLength(0); i++)
             {
                Console.Write($"{massiv[i, j]}  ");
                j = j - 1;
             }
                    
        }
    }
}
