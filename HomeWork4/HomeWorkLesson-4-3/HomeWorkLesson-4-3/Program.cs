using System;

namespace HomeWorkLesson_4_3
{
    class Program
    {
        enum Seasons
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            int monthNr;
            do {
                Console.Write("Введите номер текущего месяца: ");
                monthNr = Convert.ToInt32(Console.ReadLine());

                if (monthNr > 12)
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            while (monthNr > 12);

            int seasonNr = FindSeason(monthNr);
            string nameSeason = GetNameSeason(seasonNr);
            Console.WriteLine($"Сейчас {nameSeason}");
         
        }
        
        static int FindSeason (int nrMonth)
        {
            int nrSeason=0;
            switch (nrMonth)
            {
                case 1:
                case 2:
                case 12:
                    nrSeason = (int)Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5: 
                    nrSeason = (int)Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8: 
                    nrSeason = (int)Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    nrSeason = (int)Seasons.Summer;
                    break;
                    
            }
            return nrSeason;
        }

        static string GetNameSeason(int nomerSeason)
        {
            string seasonName = "";
            switch (nomerSeason)
            {
                case 1:
                     seasonName =  "Зима";
                        break;
                case 2:
                    seasonName = "Весна";
                    break;
                case 3:
                    seasonName = "Лето";
                    break;
                case 4:
                    seasonName = "Осень";
                    break;
            }
            return seasonName;
        }
    }
}
