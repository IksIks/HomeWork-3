using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ник первого игрока: ");
            string nick1 = Console.ReadLine();

            Console.Write("Введите ник второго игрока: ");
            string nick2 = Console.ReadLine();
            int nickNumber = 0;
            bool success = true;
            int number = 2;
            
            Random r = new Random();
            int gameNumber = r.Next(12, 50);

            while (true)
            {
                for (int i = 0; i < number; i++)
			    {
                    if(i == 0) Console.Write($"Случайное число {gameNumber} \nХод игрока {nick1}: ");                    
                    else Console.Write($"Случайное число {gameNumber} \nХод игрока {nick2}: ");
                    success = int.TryParse(Console.ReadLine(), out nickNumber);
                    while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное первым игроком значение
                    {
                        Console.Write("Вводите только числа от 1 до 4: ");
                        success = int.TryParse(Console.ReadLine(), out nickNumber);
                    }
                    gameNumber -= nickNumber;
			    }

                //if (gameNumber == 0 || gameNumber < 0)
                //{
                //    Console.WriteLine($"Выиграл игрок {nick1}");
                //    break;
                //}

                Console.Write($"Случайное число {gameNumber} \nХод игрока {nick2}: ");
                success = int.TryParse(Console.ReadLine(), out nickNumber);

                while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное вторым игроком значение
                {
                    Console.Write("Вводите только числа от 1 до 4: ");
                    success = int.TryParse(Console.ReadLine(), out nickNumber);
                }
                gameNumber -= nickNumber;
                //if (gameNumber == 0 || gameNumber < 0)
                //{
                //    Console.WriteLine($"Выиграл игрок {nick2}");
                //    break;
                //}
            }
            Console.ReadKey();
        }
    }
}
