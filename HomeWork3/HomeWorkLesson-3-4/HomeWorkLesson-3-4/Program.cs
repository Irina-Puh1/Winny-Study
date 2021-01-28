using System;

namespace HomeWorkLesson_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] koor1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            char[] koor2 = { '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            char[,] ships = new char[10, 10];
            int ship_i_begin, ship_j_begin, ship_i_end, ship_j_end;

            for (int i = 0; i < ships.GetLength(0); i++)
            {
                for (int j = 0; j < ships.GetLength(1); j++)
                {
                    ships[i, j] = 'o';
                }
            }

            Console.WriteLine("Ниже необходимо ввести координаты расположения кораблей на поле 10Х10\n");
            Console.WriteLine("Координаты должны быть введены в формате: \n" +
                "БукваЦифра(например a1), где буква - координата по горизонтали(диапозон от a до j), цифра -координата по вертикали(диапозон от 1 до 10)\n");
            Console.WriteLine("При расположении кораблей, необходимо учитывать:\n" +
                "1. 4-х палубных кораблей -1; 3-х палубных - 2; 2-х палубных - 3; 1-о палубных - 4; \n" +
                "2. Корабли не должны соприкасаться друг с другом ни палубами, ни углами");
            for (int k = 4; k >= 1; k--)
            {
                for (int nr_ships = 1; nr_ships <= (4 - (k - 1)); nr_ships++)
                {
                    if (k > 1)
                    {
                        Console.Write($"Введите начальные координаты {k} палубного корабля: ");
                        string koor_ship_b = Console.ReadLine();
                        ship_i_begin = CountKoord_i(koor_ship_b, koor2);
                        ship_j_begin = CountKoord_j(koor_ship_b, koor1);

                        Console.Write($"Введите конечные координаты {k} палубного корабля: ");
                        string koor_ship_e = Console.ReadLine();
                        ship_i_end = CountKoord_i(koor_ship_e, koor2);
                        ship_j_end = CountKoord_j(koor_ship_e, koor1);

                        if (ship_i_begin == ship_i_end)
                        {
                            for (int j = ship_j_begin; j <= ship_j_end; j++)
                            {
                                ships[ship_i_begin, j] = 'X';
                            }
                        }
                        else if (ship_j_begin == ship_j_end)
                        {
                            for (int i = ship_i_begin; i <= ship_i_end; i++)
                            {
                                ships[i, ship_j_begin] = 'X';
                            }
                        }
                    }
                    else
                    {
                        Console.Write($"Введите координаты {k} палубного корабля: ");
                        string koor_ship_b = Console.ReadLine();
                        ship_i_begin = CountKoord_i(koor_ship_b, koor2);
                        ship_j_begin = CountKoord_j(koor_ship_b, koor1);
                        ships[ship_i_begin, ship_j_begin] = 'X';
                    }

                }
            }
            for (int i=0; i<10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    Console.Write(ships[i, j]);
                }
                Console.Write("\n");
            }

        }

        static int CountKoord_i(string koor_ship, char[] koor)
        {
            int ship_i;
            if (koor_ship.Length == 3)
            {
                ship_i = 9;
            }
            else
            {
                int t = 0;
                while (koor[t] != koor_ship[1])
                    t++;

                ship_i = t;
            }
            return ship_i;
        }

        static int CountKoord_j(string koor_ship, char[] koor)
        {
            int ship_j;
            int t = 0;
            while (koor[t] != koor_ship[0])
                  t++;
            
            ship_j = t;
            return ship_j;
        }
    }
}