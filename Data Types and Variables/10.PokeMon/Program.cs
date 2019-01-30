using System;

namespace _10.PokeMon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePower = int.Parse(Console.ReadLine());
			int startPower = pokePower;
			int distance = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());
			int countPoke = 0;

			while (pokePower >= distance)
			{
				pokePower -= distance;

				if (pokePower == startPower / 2 && exhaustionFactor != 0)
				{
					if (pokePower / exhaustionFactor != 0)
					{
						pokePower /= exhaustionFactor;
					}
				}

				countPoke++;
			}

			Console.WriteLine(pokePower);
			Console.WriteLine(countPoke);
		}
	}
}
