using System;
using System.Linq;

namespace _05.Top_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(" ")
				.Select(int.Parse)
				.ToArray();
			int x = 0;

			foreach (int num in numbers)
			{
				bool top = true;

				for (int i = x + 1; i < numbers.Length; i++)
				{
					if (num <= numbers[i])
					{
						top = false;
					}
				}

				if (top == true)
				{
					Console.Write(num + " ");
				}

				x++;
			}

			Console.WriteLine();
		}
	}
}
