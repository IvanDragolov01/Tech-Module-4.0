using System;

namespace _05.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string password = ReverseString(username);
			string saveusername = Console.ReadLine();
			int br = 0;

			while (password != saveusername)
			{
				Console.WriteLine("Incorrect password. " + "Try again.");
				saveusername = Console.ReadLine();
				br++;

				if (br == 3 && password != saveusername)
				{
					Console.WriteLine($"User {username} blocked!");
					return;
				}
			}

			Console.WriteLine($"User {username} logged in.");
		}

		public static string ReverseString(string username)
		{
			char[] arr = username.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
