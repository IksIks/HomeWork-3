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
        /// <summary>
        ///В игре добавлена сложность в виде увеличенного диапазона "gameNumber"(задуманного числа) от 100 - 200
        ///и увеличенного хода игроков от 1 - 10
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите ник первого игрока: ");
            string nick1 = Console.ReadLine();

            Console.Write("Введите ник второго игрока: ");
            string nick2 = Console.ReadLine();
            int nick1Number = 0, nick2Number = 0;

            Random r = new Random();
            int gameNumber = r.Next(100, 201);

            while (true)
            {
                Console.Write($"Случайное число {gameNumber} \nХод игрока {nick1}: ");
                bool success = int.TryParse(Console.ReadLine(), out nick1Number);

                while (nick1Number > 10 || !success || nick1Number <= 0) //проверка на введенное первым игроком значение
                {
                    Console.Write("Вводите только числа от 1 до 10: ");
                    success = int.TryParse(Console.ReadLine(), out nick1Number);
                }

                gameNumber -= nick1Number;
                if (gameNumber == 0 || gameNumber < 0)
                {
                    Console.WriteLine($"Выиграл игрок {nick1}");
                    break;
                }

                Console.Write($"Случайное число {gameNumber} \nХод игрока {nick2}: ");
                success = int.TryParse(Console.ReadLine(), out nick2Number);

                while (nick2Number > 10 || !success || nick2Number <= 0) //проверка на введенное вторым игроком значение
                {
                    Console.Write("Вводите только числа от 1 до 10: ");
                    success = int.TryParse(Console.ReadLine(), out nick2Number);
                }

                gameNumber -= nick2Number;
                if (gameNumber == 0 || gameNumber < 0)
                {
                    Console.WriteLine($"Выиграл игрок {nick2}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
