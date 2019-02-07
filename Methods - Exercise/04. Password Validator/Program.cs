using System;
using System.Linq;

namespace _04._Password_Validator
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();
			string rangeVal = RangeValidator(password);
			string wordVal = WordValidator(password);
			string minCountVal = MinCountValidator(password);

			if (rangeVal != "work")
			{
				Console.WriteLine(rangeVal);
			}

			if (wordVal != "work")
			{
				Console.WriteLine(wordVal);
			}

			if (minCountVal != "work")
			{
				Console.WriteLine(minCountVal);
			}

			if (rangeVal == "work" && wordVal == "work" && minCountVal == "work")
			{
				Console.WriteLine("Password is valid");
			}
		}

		public static string RangeValidator(string password)
		{
			string result = "work";

			if (password.Length < 6 || password.Length > 10)
			{
				result = "Password must be between 6 and 10 characters";
			}

			return result;
		}

		public static string WordValidator(string password)
		{
			string result = "work";

			if (!password.All(char.IsLetterOrDigit))
			{
				result = "Password must consist only of letters and digits";
			}

			return result;
		}

		public static string MinCountValidator(string password)
		{
			string result = "work";
			int numberCount = 0;

			foreach (char value in password)
			{
				if (value >= '0' && value <= '9')
				{
					numberCount++;
				}
			}

			if (numberCount < 2)
			{
				result = "Password must have at least 2 digits";
			}

			return result;
		}
	}
}
