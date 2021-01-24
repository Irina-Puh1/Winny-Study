using System;

namespace HomeWorkLesson_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name_month = "";
            int i = 0;
            Console.WriteLine("Введите порядковый номер текущего месяца(от 1 до 12)");
            int nr_month = Convert.ToInt32(Console.ReadLine());
            switch(nr_month)
            { case 1:
                    name_month = "Январь";
                    break;
              case 2:
                    name_month = "Февраль";
                    break;
              case 3:
                    name_month = "Март";
                    break;
              case 4:
                    name_month = "Апрель";
                    break;
              case 5:
                    name_month = "Май";
                    break;
              case 6:
                    name_month = "Июнь";
                    break;
              case 7:
                    name_month = "Июль";
                    break;
              case 8:
                    name_month = "Август";
                    break;
              case 9:
                    name_month = "Сентябрь";
                    break;
              case 10:
                    name_month = "Октябрь";
                    break;
              case 11:
                    name_month = "Ноябрь";
                    break;
              case 12:
                    name_month = "Декабрь";
                    break;
              default: i = 1;
                    break; 
                     
            }
            if (i == 1)
            {
                Console.WriteLine("Месяца с таким номером не существует");
            }
            else
            {
                Console.WriteLine($"На дворе {name_month}");
            }
        }
    }
}
