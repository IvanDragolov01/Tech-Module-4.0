using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			string command;

			while ((command = Console.ReadLine()) != "END")
			{
				if (command == Reverse(command))
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
			}
		}

		public static string Reverse(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
