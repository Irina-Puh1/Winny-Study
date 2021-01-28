using System;

namespace HomeWorkLesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое слово хотите прочитать наоборот");
            string word = Console.ReadLine();
            string re_word = "";
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                re_word = re_word + word[i];
            }
            Console.WriteLine(re_word);
        }
    }
}
