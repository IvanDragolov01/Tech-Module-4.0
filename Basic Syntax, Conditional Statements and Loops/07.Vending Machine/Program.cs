using System;
using System.Linq;

namespace _07.Vending_Machine
{
	class Program
	{
		static void Main(string[] args)
		{
			double coins;
			double pocket = 0;
			string command;

			while ((command = Console.ReadLine()) != "Start")
			{
				coins = double.Parse(command);
				pocket += coins;

				if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
				{
					Console.WriteLine($"Cannot accept {coins}");
					pocket -= coins;
				}
			}

			while ((command = Console.ReadLine()) != "End")
			{
				string food = command;
				double priceFood = 0;

				switch (food)
				{
					case "Nuts":
						priceFood = 2.0;
						break;
					case "Water":
						priceFood = 0.7;
						break;
					case "Crisps":
						priceFood = 1.5;
						break;
					case "Soda":
						priceFood = 0.8;
						break;
					case "Coke":
						priceFood = 1.0;
						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}

				if (pocket >= priceFood && priceFood > 0)
				{
					string productToLower = food.ToLower();
					Console.WriteLine($"Purchased {productToLower}");
					pocket -= priceFood;
				}
				else if (priceFood > 0)
				{
					Console.WriteLine("Sorry, not enough money");
				}
			}

			Console.WriteLine($"Change: {pocket:f2}");
		}
	}
}

