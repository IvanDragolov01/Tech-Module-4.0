using System;
using System.Linq;

namespace _08.Magic_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int magicNumber = int.Parse(Console.ReadLine());
			int x = 0;

			foreach (int num in numbers)
			{
				int sum = numbers[x];

				for (int i = x + 1; i < numbers.Length; i++)
				{
					sum += numbers[i];

					if (sum == magicNumber)
					{
						Console.WriteLine($"{numbers[x]} {numbers[i]}");
					}

					sum = numbers[x];
				}

				x++;
			}
		}
	}
}
