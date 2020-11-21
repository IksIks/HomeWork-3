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
            Console.Write("Введите количество игроков: ");
            int number = int.Parse(Console.ReadLine());
            string[] nicks = new string[number];

            for (int i = 0; i < nicks.Length; i++)
			{
                Console.Write($"Введите ник {i + 1} игрока: ");
                nicks[i] = Console.ReadLine();
			}
            int nickNumber = 0;
            Random r = new Random();
            char answer = 'д';
            int gameNumber = r.Next(12, 50);            
            while(answer == 'д')
            {
                for (int i = 0; i < nicks.Length; i++)
                {                
                    Console.Write($"Случайное число {gameNumber} \nХод игрока {nicks[i]}: ");
                    bool success = int.TryParse(Console.ReadLine(), out nickNumber);
                    while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное первым игроком значение
                    {
                        Console.Write("Вводите только числа от 1 до 4: ");
                        success = int.TryParse(Console.ReadLine(), out nickNumber);
                    }
                    gameNumber -= nickNumber;
                    if (gameNumber == 0 || gameNumber < 0)
                    {
                        Console.WriteLine($"Значение равно нулю. Выиграл игрок {nicks[i]}");
                        Console.WriteLine("Реванш ? д/н");
                        answer = Console.ReadKey().KeyChar;
                        if(answer == 'д') gameNumber = r.Next(12, 50);
                        else break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
