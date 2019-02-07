using System;

namespace _8._Factorial_Division
{
	class Program
	{
		static void Main(string[] args)
		{
			long firstNumber = long.Parse(Console.ReadLine());
			long secondNumber = long.Parse(Console.ReadLine());
			double result = CalculateFactorial(firstNumber) / CalculateFactorial(secondNumber);
			Console.WriteLine($"{result:F2}");
		}

		public static double CalculateFactorial(long factorial)
		{
			if (factorial == 0)
			{
				return 1;
			}
			else
			{
				return factorial * CalculateFactorial(factorial - 1);
			}
		}
	}
}
