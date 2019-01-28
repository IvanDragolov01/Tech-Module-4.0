using System;

namespace _08._Beer_Kegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double calculate = 0;
			double max = 0;
			string savemodel = "";

			for (int i = 0; i < n; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());
				double radius2 = radius * radius;
				calculate = Math.PI * radius2 * height;

				if (max <= calculate)
				{
					max = calculate;
					savemodel = model;
				}
			}

			Console.WriteLine(savemodel);
		}
	}
}
