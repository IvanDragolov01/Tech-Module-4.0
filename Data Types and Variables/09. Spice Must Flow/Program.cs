using System;

namespace _09._Spice_Must_Flow
{
	class Program
	{
		static void Main(string[] args)
		{
			int yield = int.Parse(Console.ReadLine());

			if (yield < 0)
			{
				Console.WriteLine("Invalid input");
				return;
			}

			int consume = 26;
			int day = 0;
			int totalAmount = 0;

			while (yield >= 100)
			{
				if (yield <= consume)
				{
					yield = 0;
				}

				totalAmount += yield - consume;
				day++;
				yield -= 10;
			}

			if (yield < 100)
			{
				if (totalAmount >= consume)
				{
					totalAmount -= consume;
				}
			}
			else
			{
				Console.WriteLine("Yield cannot be null");
				return;
			}

			Console.WriteLine(day);
			Console.WriteLine(totalAmount);
		}
	}
}
