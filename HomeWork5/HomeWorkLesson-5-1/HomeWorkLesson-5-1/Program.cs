using System;
using System.IO;

namespace HomeWorkLesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для записи в файл:  ");
            string someText = Console.ReadLine();
            Console.Write("Введите имя файла, в который необходимо поместить текст \n (используйте латинскую раскладку клавиатуры): ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".txt";
            string workDir = @"D:\ExampleDir\HomeW";
            if (Directory.Exists(workDir) == false)
            {
                Directory.CreateDirectory(workDir);
            }

            string fileNamePath = Path.Combine(workDir, fileName);
           
            File.WriteAllText(fileNamePath, someText);

        }
    }
}
