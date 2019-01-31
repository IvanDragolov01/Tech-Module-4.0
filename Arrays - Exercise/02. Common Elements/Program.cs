using System;

namespace _02._Common_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] lineOne = Console.ReadLine().Split(" ");
			string[] lineTwo = Console.ReadLine().Split(" ");

			for (int i = 0; i < lineOne.Length; i++)
			{
				for (int j = 0; j < lineTwo.Length; j++)
				{
					if (lineOne[i] == lineTwo[j])
					{
						Console.Write(lineOne[i] + " ");
					}
				}
			}
		}
	}
}
