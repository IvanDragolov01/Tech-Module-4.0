using System;

namespace _10.Rage_Expenses
{
	class Program
	{
		static void Main(string[] args)
		{
			int lostGames = int.Parse(Console.ReadLine());
			double headsetPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displayPrice = double.Parse(Console.ReadLine());
			double money = 0;
			int trashedKeyboardCount = 0;

			for (int game = 1; game <= lostGames; game++)
			{


				if (game % 2 == 0)
				{
					money += headsetPrice;
				}

				if (game % 3 == 0)
				{
					money += mousePrice;
				}

				if (game % 2 == 0 && game % 3 == 0)
				{
					money += keyboardPrice;
					trashedKeyboardCount++;

					if (trashedKeyboardCount % 2 == 0)
					{
						money += displayPrice;
					}
				}
			}

			Console.WriteLine($"Rage expenses: {money:f2} lv.");
		}
	}
}
