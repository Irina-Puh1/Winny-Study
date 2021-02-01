using System;

namespace HomeWorkLesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите строку из чисел, разделенных между собой пробелом.\n При вводе дробного числа, для разделения дробной и целой части используйте ','");
            Console.WriteLine();
            string line = Console.ReadLine();
            string pattern = @"\s+";
            string[] separate_line = System.Text.RegularExpressions.Regex.Split(line, pattern);
            double summ = 0;

            for (int i=0; i < separate_line.Length; i++)
            {
                 summ = summ + float.Parse(separate_line[i]);
                 summ = Math.Round(summ, 2);
            }

            Console.WriteLine($"Сумма всех введенных чисел равна: {summ}");
        }
    }
}
