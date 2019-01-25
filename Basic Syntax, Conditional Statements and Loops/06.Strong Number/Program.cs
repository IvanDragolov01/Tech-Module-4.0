using System;

namespace _06.Strong_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int savenumber = number;
			int sum = 0;
			

			while (number > 0)
			{
				int porcent = 1;
				int a = number % 10;

				if (a != 0)
				{
					for (int i = 1; i <= a; i++)
					{
						porcent = porcent * i;
					}

					sum += porcent;
				}

				number = number / 10;
			}

			if (sum == savenumber)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
