using System;
using System.Diagnostics; 

namespace HomeWorkLesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] localProc = Process.GetProcesses();

            for (int i = 0; i< localProc.Length; i++)
                Console.WriteLine($"{localProc[i]} {localProc[i].Id}" );
            Console.Write ("Что необхоидимо использовать для остановки процесса?\n " +
                "1. если идентификационный номер процесса - нажмите 1\n " +
                "2. если имя процесса - нажмите 2");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    {
                        Console.Write("Введите Id процесса, \n работу которого в настоящее время необходимо прекратить: ");
                        int idProc = int.Parse(Console.ReadLine());
                        StopProcessById(idProc);
                        break;
                    }
                    
                case 2: 
                    {
                        Console.Write("Введите имя процесса, \n работу которого в настоящее время необходимо прекратить: ");
                        string nameProc = Console.ReadLine();
                        StopProcessByName(nameProc);
                        break;
                    }
                default:
                    Console.WriteLine("Не введено ни одного процесса, действие которого необходимо завершить");
                    break;
            }
            
        }

        static void StopProcessById(int idPrc) 
        {
            Process localPrc = Process.GetProcessById(idPrc);
            localPrc.Kill();
        }

        static void StopProcessByName (string namePrc)
        {
            Process[] localPrc = Process.GetProcessesByName(namePrc);
            for (int i = 0; i < localPrc.Length; i++)
            {
                Console.WriteLine($"{localPrc[i]} {localPrc[i].Id}");
                localPrc[i].Kill();
            }
            
        }
    }
}
