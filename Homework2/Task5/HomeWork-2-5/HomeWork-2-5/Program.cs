using System;

namespace HomeWork_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифрами минимальную температуру воздуха за прошедшие сутки:");
            float min_temp = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифрами максимальную температуру воздуха за прошедшие сутки:");
            float max_temp = float.Parse(Console.ReadLine());
            float middle_temp = (min_temp + max_temp) / 2;

            Console.WriteLine("Введите порядковый номер текущего месяца(от 1 до 12)");
            int nr_month = Convert.ToInt32(Console.ReadLine());
            string name_month = "";
            int i = 0;

            switch (nr_month)
            {
                case 1:
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
                default:
                    i = 1;
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

            
            Console.WriteLine($"Средняя температура за прошедшие сутки составила: \n {middle_temp} градусов Цельсия");
            if ((nr_month == 1 || nr_month == 2 || nr_month == 12) && middle_temp > 0 && i!=1)

                Console.WriteLine("Дождливая зима");
        }
    }        
}
