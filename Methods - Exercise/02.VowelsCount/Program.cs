using System;

namespace _02.VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			Console.WriteLine(VowelCount(text));
		}

		public static int VowelCount(string a)
		{
			int vowelCount = 0;
			a = a.ToLower();
			char[] p = a.ToCharArray();

			for (int i = 0; i < p.Length; i++)
			{
				if (p[i] == 'a' || p[i] == 'u' || p[i] == 'o' || p[i] == 'e' || p[i] == 'i')
				{
					vowelCount++;
				}
			}

			return vowelCount;
		}
	}
}
