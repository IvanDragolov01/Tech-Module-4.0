using System;

namespace _10.Top_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int startIndex = int.Parse(Console.ReadLine());
			int sumOfDigits = 0;
			int br = 0;
			Digits(startIndex, sumOfDigits, br);
		}

		private static void Digits(int startIndex, int sumOfDigits, int br)
		{
			for (int i = 1; i <= startIndex; i++)
			{
				int p = i;

				sumOfDigits = 0;
				br = 0;

				while (p > 0)
				{
					int num = p % 10;
					sumOfDigits += num;

					if (num % 2 != 0)
					{
						br++;
					}

					p /= 10;
				}

				if (sumOfDigits % 8 == 0 && br >= 1)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}