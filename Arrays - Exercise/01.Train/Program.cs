using System;
using System.Linq;

namespace _01.Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int train = int.Parse(Console.ReadLine());
			int[] members = new int[train];
			int sum = 0;

			for (int i = 0; i < train; i++)
			{
				int number = int.Parse(Console.ReadLine());
				members[i] = number;
				sum += number;
			}

			for (int i = 0; i < train; i++)
			{
				Console.Write(members[i] + " ");
			}

			Console.WriteLine();
			Console.WriteLine(sum);
		}
	}
}
