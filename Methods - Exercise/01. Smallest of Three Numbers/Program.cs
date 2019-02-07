using System;

namespace _01._Smallest_of_Three_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int lastNumber = int.Parse(Console.ReadLine());
			Console.WriteLine(MinValue(firstNumber, secondNumber, lastNumber));
		}

		public static int MinValue(int firstNumber, int secondNumber, int lastNumber)
		{
			int min = 0;

			if (firstNumber < secondNumber && firstNumber < lastNumber)
			{
				min = firstNumber;
			}
			else if (secondNumber < firstNumber && secondNumber < lastNumber)
			{
				min = secondNumber;
			}
			else
			{
				min = lastNumber;
			}

			return min;
		}
	}
}

