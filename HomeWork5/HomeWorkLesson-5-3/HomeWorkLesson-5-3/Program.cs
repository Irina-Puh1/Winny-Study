using System;
using System.IO;


namespace HomeWorkLesson_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел(от 0 до 255): ");
            string someText = Console.ReadLine();

            string[] someT = someText.Split(' ');
            int[] someTx = new int[someT.Length - 1];
            byte[] figures = new byte[someT.Length - 1];
            for (int i = 0; i < someT.Length - 1; i++)
            {
                someTx[i] = int.Parse(someT[i]);
                figures[i] = (byte)someTx[i];
            }

            Console.Write("Введите имя файла, в который необходимо поместить текст \n (используйте латинскую раскладку клавиатуры): ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".bin";
            string workDir = @"D:\ExampleDir\HomeW";
            Directory.CreateDirectory(workDir);
            string fileNamePath = Path.Combine(workDir, fileName);
            File.Exists(fileNamePath);
            File.WriteAllBytes(fileNamePath, figures);

        }
    }
}
