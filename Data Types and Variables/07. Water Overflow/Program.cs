using System;

namespace _07._Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int line = int.Parse(Console.ReadLine());
			int capacityWaterTank = 255;
			int letersWater = 0;

			for (int i = 0; i < line; i++)
			{
				int addWater = int.Parse(Console.ReadLine());

				if (addWater > capacityWaterTank)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					capacityWaterTank -= addWater;
					letersWater += addWater;
				}
			}

			Console.WriteLine(letersWater);
		}
	}
}
