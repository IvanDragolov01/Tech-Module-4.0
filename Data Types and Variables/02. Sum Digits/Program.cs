using System;

namespace _02._Sum_Digits
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int sum = 0;

			while (number > 0)
			{
				int a = number % 10;
				sum += a;
				number = number / 10;
			}

			Console.WriteLine(sum);
		}
	}
}
