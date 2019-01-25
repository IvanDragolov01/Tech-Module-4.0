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

			int trashedHeadsetCount = 0;
			int trashedMouseCount = 0;
			int trashedKeyboardCount = 0;
			int trashedDisplayCount = 0;

			for (int game = 1; game <= lostGames; game++)
			{
				if (game % 2 == 0)
				{
					trashedHeadsetCount++;
				}

				if (game % 3 == 0)
				{
					trashedMouseCount++;
				}

				if (game % 2 == 0 && game % 3 == 0)
				{
					trashedKeyboardCount++;

					if (trashedKeyboardCount % 2 == 0)
					{
						trashedDisplayCount++;
					}
				}
			}

			double headsetTotalPrice = headsetPrice * trashedHeadsetCount;
			double mouseTotalPrice = mousePrice * trashedMouseCount;
			double keyboardsTotalPrice = keyboardPrice * trashedKeyboardCount;
			double displayTotalPrice = displayPrice * trashedDisplayCount;
			double sumOfHeadsetAndMouse = headsetTotalPrice + mouseTotalPrice;
			double sumOfKeyboardsAndDisplay = keyboardsTotalPrice + displayTotalPrice; 
			double totalExpenses = sumOfHeadsetAndMouse + sumOfKeyboardsAndDisplay;

			Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
		}
	}
}
