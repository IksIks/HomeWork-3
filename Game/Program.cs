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
            int nickNumber = 0;     //ход игроков от 1-4
            bool success = true;
            string playersMove = String.Empty;
            char answer = 'д';
            
            Random r = new Random();
            int gameNumber = r.Next(12, 50);
            bool revenge = true;

            while (revenge)
            {
                for (int i = 0; i < 2; i++)
			    {
                    if(i == 0) playersMove = nick1;
                    else playersMove = nick2;
                    Console.Write($"Случайное число {gameNumber} \nХод игрока {playersMove}: ");
                    success = int.TryParse(Console.ReadLine(), out nickNumber);
                    while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное первым игроком значение
                    {
                        Console.Write("Вводите только числа от 1 до 4: ");
                        success = int.TryParse(Console.ReadLine(), out nickNumber);
                    }
                    gameNumber -= nickNumber;
			        if (gameNumber == 0 || gameNumber < 0)
                    {
                        Console.WriteLine($"Выиграл игрок {playersMove}");
                        Console.Write("Реванш ? д/н");
                        revenge = (answer == 'д')
                    }
                }
               
            }
            Console.ReadKey();
        }
    }
}
