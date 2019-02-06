using System;

namespace _07._NxN_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Console.Write(Matrix(number));
		}

		public static string Matrix(int a)
		{
			int[] matrix = new int[a];
			int[] matrix2 = new int[a];

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix2.Length - 1; j++)
				{
					Console.Write(a + " ");
				}

				Console.WriteLine(a);
			}

			return "";
		}
	}
}
