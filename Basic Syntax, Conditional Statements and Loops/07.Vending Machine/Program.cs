using System;
using System.Linq;

namespace _07.Vending_Machine
{
	class Program
	{
		static void Main(string[] args)
		{
			double coins;
			double priceFood = 0;
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

				switch (food)
				{
					case "Nuts":
						priceFood = 2.0;

						if (pocket < priceFood)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else if (pocket >= priceFood)
						{
							pocket -= priceFood;
							Console.WriteLine($"Purchased {food.ToLower()}");
						}

						break;
					case "Water":
						priceFood = 0.7;

						if (pocket < priceFood)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else if (pocket >= priceFood)
						{
							pocket -= priceFood;
							Console.WriteLine($"Purchased {food.ToLower()}");
						}

						break;
					case "Crisps":
						priceFood = 1.5;

						if (pocket < priceFood)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else if (pocket >= priceFood)
						{
							pocket -= priceFood;
							Console.WriteLine($"Purchased {food.ToLower()}");
						}

						break;
					case "Soda":
						priceFood = 0.8;

						if (pocket < priceFood)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else if (pocket >= priceFood)
						{
							pocket -= priceFood;
							Console.WriteLine($"Purchased {food.ToLower()}");
						}

						break;
					case "Coke":
						priceFood = 1.0;

						if (pocket < priceFood)
						{
							Console.WriteLine("Sorry, not enough money");
						}
						else if (pocket >= priceFood)
						{
							pocket -= priceFood;
							Console.WriteLine($"Purchased {food.ToLower()}");
						}

						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}
			}

			Console.WriteLine($"Change: {pocket:f2}");
		}
	}
}

