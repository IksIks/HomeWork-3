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
			Console.WriteLine("Выбирете варианты игры: \n- Простая, 2 игрока - нажмите 1\n- Сложная, 2 игрока - нажмите 2" +
							  "\n- C компьютером - нажмите 3");
			int choise = int.Parse(Console.ReadLine());
			Console.Write("Введите ник первого игрока: ");
			string nick1 = Console.ReadLine();
			int min = 12, max = 27;
			string nick2 = String.Empty;
			int minValue = 1, maxValue = 4;
			string playersMove;       //переменная для хранения ников игроков
			int nickNumber = 0;       //ход игроков от 1-4
			
			switch (choise)
			{
				case 1:
					Console.Write("Введите ник второго игрока: ");
					nick2 = Console.ReadLine();
					break;
				case 2:
					Console.Write("Введите ник второго игрока: ");
					nick2 = Console.ReadLine();
					min = 100;
					max = 200;
					minValue = 1;
					maxValue = 10;
					break;
				case 3:
					Console.WriteLine("Ник второго игрока: Stupid Comp");
					nick2 = "Stupid Comp";
					break;
			}

			Random r = new Random();
			int gameNumber = r.Next(min, max);
			bool revenge = true;

			while (revenge)
			{
				for (int i = 0; i < 2; i++)
				{
					if (i == 0)
						playersMove = nick1;
					else
						playersMove = nick2;

					if (playersMove == "Stupid Comp" && gameNumber > 10)
					{
						nickNumber = r.Next(1, 5);
						Console.Write($"\nСлучайное число {gameNumber} \nХод игрока {playersMove}: {nickNumber}");
					}
					else
					{
						Console.Write($"\nСлучайное число {gameNumber} \nХод игрока {playersMove}: ");
						bool success = int.TryParse(Console.ReadLine(), out nickNumber);
						while (nickNumber > maxValue || !success || nickNumber <= 0)
						{
							Console.Write($"Вводите только числа от {minValue} до {maxValue}: ");
							success = int.TryParse(Console.ReadLine(), out nickNumber);
						}
					}
					if (playersMove != "Stupid Comp" || (playersMove == "Stupid Comp" && (gameNumber > 10)))
						gameNumber -= nickNumber;

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
								gameNumber -= nickNumber;
								Console.WriteLine($"Ход игрока Stupid Comp: {playersMove}\n");
								break;
							default:
								gameNumber = 0;
								break;
						}
					}
					if(gameNumber == 0 || gameNumber < 0)
					{
						Console.WriteLine($"Значаение числа равно нулю. \nВыиграл игрок {playersMove}");
						Console.Write("Реванш ? д/н ");
						char answer = Console.ReadKey().KeyChar;
						gameNumber = r.Next(min, max);
						revenge = (answer == 'д')?true:false;
						break;
					}
				}               
			}
			Console.ReadKey();
		}
	}
}
