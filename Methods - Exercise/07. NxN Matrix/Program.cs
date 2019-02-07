using System;

namespace _07._NxN_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Matrix(number);
		}

		public static void Matrix(int input)
		{
			int[] matrix = new int[input];
			int[] matrix2 = new int[input];

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix2.Length - 1; j++)
				{
					Console.Write(input + " ");
				}

				Console.WriteLine(input);
			}
		}
	}
}
