using System;

namespace Algorithm1_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static int StrangeSum(int[] inputArray)
        {
            //Сложность операций присваивания от N не зависит, т.е. все операции присваивания вне циклов будут O(1)
            //Внешний цикл повторяется N раз, Средний цикл тоже N раз, Внутреннй цикл также N раз
            //Каждая операция присваивания внутри цикла это тоже O(1). Внутри цикла таких операций 3, т.е. 2 X O(1)
            //Общая сложность циклов составит (O(N*3)) X  (3 X O(1)) - примем, что в большинстве случаев j!=0
            //и общая сложность функции  - O(N*3) X  (3 X O(1)) + (2 X O(1))
            //т.к. часть (2XO(1) + (3 X O(1))) не зависит от N, то ее можно отбросить.
            //Таким образом сложность функции можно принять за O(N*3) (N в кубе).


            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0; // O(1)

                        if (j != 0)
                        {
                            y = k / j; //O(1)
                        }

                        sum += inputArray[i] + i + k + j + y;// О(1)
                    }
                }
            }

            return sum;
        }

    }
}
