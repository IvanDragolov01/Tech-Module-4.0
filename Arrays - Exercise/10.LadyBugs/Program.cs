using System;
using System.Linq;

namespace _10.LadyBugs
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[] indexes = Console.ReadLine().Split("").Select(int.Parse).ToArray();
			string command;
			int x = 0;

			while ((command = Console.ReadLine()) != "end")
			{
				switch (command)
				{
					case "right":

						break;
					case "left":
					default:
						Console.WriteLine("Invalid command");
						break;
				}
			}

			Console.WriteLine($" ");
		}
	}
}
