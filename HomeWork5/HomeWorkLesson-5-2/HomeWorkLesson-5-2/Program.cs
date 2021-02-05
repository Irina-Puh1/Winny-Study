using System;
using System.IO;

namespace HomeWorkLesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nowTime = DateTime.Now.ToString("HH:mm:ss");
            string fileName = "startup.txt";
            string workDir = @"D:\ExampleDir\HomeW";
            if (Directory.Exists(workDir) == false)
            {
                Directory.CreateDirectory(workDir);
            }

            string fileNamePath = Path.Combine(workDir, fileName);
            File.AppendAllText(fileNamePath, Environment.NewLine);
            File.AppendAllText(fileNamePath, nowTime);

        }
    }
}