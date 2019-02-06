using System;

namespace _01._Smallest_of_Three_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			Console.WriteLine(MinValue(a, b, c));
		}

		public static int MinValue(int a, int b, int c)
		{
			int min = 0;

			if (a < b && a < c)
			{
				min = a;
			}
			else if (b < a && b < c)
			{
				min = b;
			}
			else
			{
				min = c;
			}

			return min;
		}
	}
}

