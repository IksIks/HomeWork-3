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
            int nickNumber = 0;                     //ход игроков от 1-4            
            string playersMove = String.Empty;      //переменная для хранения ников игроков
            char answer = 'д';                      //ответ для реванша
            
            Random r = new Random();
            int gameNumber = r.Next(12, 13);
            bool revenge = true;

            while (revenge)
            {
                for (int i = 0; i < 2; i++)
			    {
                    if(i == 0) playersMove = nick1;
                    else playersMove = nick2;
                    Console.Write($"\nСлучайное число {gameNumber} \nХод игрока {playersMove}: ");
                    bool success = int.TryParse(Console.ReadLine(), out nickNumber);
                    while (nickNumber > 4 || !success || nickNumber <= 0) //проверка на введенное первым игроком значение
                    {
                        Console.Write("Вводите только числа от 1 до 4: ");
                        success = int.TryParse(Console.ReadLine(), out nickNumber);
                    }
                    gameNumber -= nickNumber;
			        if (gameNumber == 0 || gameNumber < 0)
                    {
                        Console.WriteLine($"Значаение числа равно нулю. Выиграл игрок {playersMove}");
                        Console.Write("Реванш ? д/н ");
                        answer = Console.ReadKey().KeyChar;
                        gameNumber = r.Next(12, 51);
                        revenge = (answer == 'д')?true:false;
                        break;
                    }
                }
               
            }
            Console.ReadKey();
        }
    }
}
