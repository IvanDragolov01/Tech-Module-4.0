using System;

namespace _03._Characters_in_Range
{
	class Program
	{
		static void Main(string[] args)
		{
			char startIndex = char.Parse(Console.ReadLine());
			char lastIndex = char.Parse(Console.ReadLine());

			string result = Range(startIndex, lastIndex);
			Console.Write(result);
			Console.WriteLine();
		}

		public static string Range(char a, char b)
		{
			string range = null;

			if (a < b)
			{
				for (int i = a + 1; i < b; i++)
				{
					range += (char)i + " ";
				}
			}
			else
			{
				for (int i = b + 1; i < a; i++)
				{
					range += (char)i + " ";
				}
			}

			return range + " ";
		}
	}
}
