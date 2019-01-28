using System;

namespace _03._Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int people = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			int br = 0;

			while (people > 0)
			{
				people = people - capacity;
				br++;
			}

			Console.WriteLine(br);
		}
	}
}
