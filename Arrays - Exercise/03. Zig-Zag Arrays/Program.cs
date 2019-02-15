	using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int numbers = int.Parse(Console.ReadLine());
			int[] first = new int[numbers];
			int[] second = new int[numbers];
			int x = 0;

			for (int i = 0; i < numbers; i++)
			{
				int[] n = Console.ReadLine().Split(" ")
					.Select(int.Parse)
					.ToArray();

				if (i % 2 == 0)
				{
					first[x] = n[0];
					second[x] = n[1];
					x++;
				}
				else if (i % 2 != 0)
				{
					first[x] = n[1];
					second[x] = n[0];
					x++;
				}
			}

			Console.WriteLine(string.Join(" ", first));
			Console.WriteLine(string.Join(" ", second));

			//foreach (int number in first)
			//{
			//	Console.Write(number + " ");
			//}

			//Console.WriteLine();

			//foreach (int number in second)
			//{
			//	Console.Write(number + " ");
			//}
		}
	}
}
