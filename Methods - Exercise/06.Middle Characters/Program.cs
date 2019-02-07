using System;

namespace _06.Middle_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Console.WriteLine(MiddleCharacters(input));
		}

		public static string MiddleCharacters(string middlesymbol)
		{
			string result = string.Empty;

			if (middlesymbol.Length % 2 == 0)
			{
				int firstIndex = (middlesymbol.Length / 2) - 1;
				int secondIndex = (middlesymbol.Length / 2);
				result = $"{middlesymbol[firstIndex]}{middlesymbol[secondIndex]}";
			}
			else
			{
				int middleIndex = middlesymbol.Length / 2;
				result = $"{middlesymbol[middleIndex]}";
			}

			return result;
		}
	}
}
