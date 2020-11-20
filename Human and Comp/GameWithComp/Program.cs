using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main()
        {

            Console.Write("Введите свой ник: ");
            string nick1 = Console.ReadLine();

            Console.WriteLine("Ник второго игрока: Stupid Comp");
            int nick1Number = 0, compNumber = 0;
            Random r = new Random();
            int gameNumber = r.Next(12, 51);

            while (true)
            {
                Console.Write($"Случайное число {gameNumber}\nХод игрока {nick1}: ");
                bool success = int.TryParse(Console.ReadLine(), out nick1Number);

                while (nick1Number > 4 || !success || nick1Number <= 0) //проверка на введенное игроком значение
                {
                    Console.Write("Вводите только числа от 1 до 4: ");
                    success = int.TryParse(Console.ReadLine(), out nick1Number);
                }

                gameNumber -= nick1Number;
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Выиграл игрок {nick1}");
                    break;
                }

                Console.WriteLine($"Случайное число {gameNumber}\n");

                compNumber = r.Next(1, 5);                                          // ход компьютера в диапазоне от 1 до 4
                if (gameNumber > 10)                                                //
                {                                                                   // рандомные ходы для разнообразия игры
                    gameNumber -= compNumber;                                       // до значения 10, далее другая логика
                    Console.WriteLine($"Ход игрока Stupid Comp: {compNumber}\n");   // компьютера
                }
                else
                {
                    switch (gameNumber)
                    {
                        case 10:
                            gameNumber = 10 - 3;
                            Console.WriteLine($"Ход игрока Stupid Comp: 3\n");
                            break;
                        case 9:
                            gameNumber = 9 - 2;
                            Console.WriteLine($"Ход игрока Stupid Comp: 2\n");
                            break;
                        case 8:
                            gameNumber = 8 - 1;
                            Console.WriteLine($"Ход игрока Stupid Comp: 1\n");
                            break;
                        case 7:
                            gameNumber = 7 - 2;
                            Console.WriteLine($"Ход игрока Stupid Comp: 2\n");
                            break;
                        case 6:
                            gameNumber = 6 - 1;
                            Console.WriteLine($"Ход игрока Stupid Comp: 1\n");
                            break;
                        case 5:
                            gameNumber -= compNumber;
                            Console.WriteLine($"Ход игрока Stupid Comp: {compNumber}\n");
                            break;
                        default:
                            compNumber = 0;
                            break;
                    }
                }
                if (compNumber == 0)
                {
                    Console.WriteLine($"Выиграл игрок Stupid Comp, его ход {gameNumber}");
                    break;
                }


            }
            Console.ReadKey();


        }
    }
}