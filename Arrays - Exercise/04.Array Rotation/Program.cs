using System;
using System.Linq;

namespace _04.Array_Rotation
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] members = Console.ReadLine().Split(" ")
				.Select(int.Parse)
				.ToArray();

			int startIndex = int.Parse(Console.ReadLine());

			if (startIndex > members.Length)
			{
				startIndex -= members.Length;
			}

			for (int i = startIndex; i < members.Length; i++)
			{
				Console.Write(members[i] + " ");
			}

			for (int i = 0; i < startIndex; i++)
			{
				Console.Write(members[i] + " ");
			}

			Console.WriteLine();
		}
	}
}
