using System;

namespace HomeWorkLesson_2_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string title = "             Кассовый чек                       \n " +
                           "             ООО Ромашка\n " +
                           "            Продажа №111111";
            string good1 = "Кофе";
            string good2 = "Рис";
            double price1 = 250.25;
            double price2 = 58.65;
            int n1 = 2;
            int n2 = 3;
            double TotalPrice = price1 * n1 + price2 * n2;
            DateTime dateAndTime = new DateTime(2020, 12, 15, 14, 15, 10);

            Console.WriteLine(title);
            Console.WriteLine("");
            Console.WriteLine($" {good1}    {price1}   {n1}   {price1*n1}");
            Console.WriteLine($" {good2}     {price2}    {n2}   {price2*n2}");
            Console.WriteLine("");
            Console.WriteLine($" К оплате                 {TotalPrice}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"        {dateAndTime}");
           
            Console.WriteLine("");
            Console.WriteLine("        Спасибо за покупку");


            
        }
    }
}
