using System;

namespace _08._Triangle_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());

			for (int i = 1; i <= a; i++)
			{
				for (int j = 0; j < i-1; j++)
				{
					Console.Write(i+ " ");
				}

				Console.WriteLine(i);
			}
		}
	}
}
