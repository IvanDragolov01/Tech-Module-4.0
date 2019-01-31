using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int length = 1;
			int index = 0;
			int maxLength = 1;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] == numbers[i - 1])
				{
					length++;

					if (length > maxLength)
					{
						maxLength = length;
						index = numbers[i];
					}
				}

				else
				{
					length = 1;
				}
			}

			for (int i = 0; i < maxLength; i++)
			{
				Console.Write(index + " ");
			}
		}
	}
}
