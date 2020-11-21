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
            Console.WriteLine("Введите количество игроков: ");
            int number = int.Parse(Console.ReadLine());
            string[] nicks = new string[number];

            for (int i = 0; i < nicks.Length; i++)
			{
                Console.Write($"Введите ник {i} игрока: ");
                nicks[i] = Console.ReadLine();
			}
            string nickFirst = Console.ReadLine();

            Console.Write("Введите ник второго игрока: ");
            string nickSecond = Console.ReadLine();
            string nick = String.Empty;
            int nickNumber = 0;

            Random r = new Random();
            int gameNumber = r.Next(12, 50);

            while (true)
            {                
                Console.Write($"Случайное число {gameNumber} \nХод игрока {nick}: ");
                bool success = int.TryParse(Console.ReadLine(), out nickNumber);

                while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное первым игроком значение
                {
                    Console.Write("Вводите только числа от 1 до 4: ");
                    success = int.TryParse(Console.ReadLine(), out nickNumber);
                }
                gameNumber -= nickNumber;
                if (gameNumber == 0 || gameNumber < 0)
                {
                    Console.WriteLine($"Выиграл игрок {nick}");
                    break;
                }


                //Console.Write($"Случайное число {gameNumber} \nХод игрока {Second}: ");
                //success = int.TryParse(Console.ReadLine(), out nickNumber);

                //while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное вторым игроком значение
                //{
                //    Console.Write("Вводите только числа от 1 до 4: ");
                //    success = int.TryParse(Console.ReadLine(), out nickNumber);
                //}
                //gameNumber -= nickNumber;
                //if (gameNumber == 0 || gameNumber < 0)
                //{
                //    Console.WriteLine($"Выиграл игрок {Second}");
                //    break;
                //}
            }
            Console.ReadKey();
        }
    }
}
