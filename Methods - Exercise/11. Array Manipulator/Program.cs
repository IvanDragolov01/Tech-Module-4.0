using System;
using System.Linq;

namespace _11._Array_Manipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			string[] command = Console.ReadLine().Split();

			while (command[0] != "end")
			{
				if (command[0] == "max" && command[1] == "odd")
				{
					int maxOdd = 0;

					for (int i = 0; i < input.Length; i++)
					{
						if (maxOdd < i && i % 2 == 0)
						{
							maxOdd = i;
						}
					}
				}

				else if(command[0] == "max" && command[1] == "even")
				{
					int maxEven = 0;

					for (int i = 0; i < input.Length; i++)
					{
						if (maxEven < i && i % 2 != 0)
						{
							maxEven = i;
						}
					}
				}

				if (command[0] == "min" && command[1] == "odd")
				{
					int minOdd = 0;

					for (int i = 0; i < input.Length; i++)
					{
						if (minOdd > i && i % 2 == 0)
						{
							minOdd = i;
						}
					}
				}

				else if (command[0] == "min" && command[1] == "even")
				{
					int minEven = 0;

					for (int i = 0; i < input.Length; i++)
					{
						if (minEven > i && i % 2 != 0)
						{
							minEven = i;
						}
					}

					if (minEven > 0)
					{
						Console.WriteLine($"[{minEven}]");
					}
				}
			}
		}
	}
}
