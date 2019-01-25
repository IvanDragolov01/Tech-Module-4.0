using System;

namespace _09._Padawan_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			double discountBelt = 0;
			int countStudents = int.Parse(Console.ReadLine());
			double priceLightsaber = double.Parse(Console.ReadLine());
			double priceRobe = double.Parse(Console.ReadLine());
			double priceBelt = double.Parse(Console.ReadLine());
			int allLightsaber = (int)Math.Ceiling(countStudents * 0.1) + countStudents;
			double priceAllLightsaber = allLightsaber * priceLightsaber;
			double priceAllBelt = countStudents * priceBelt;
			double priceAllRobe = countStudents * priceRobe;
			int freeBelts = countStudents / 6;
			discountBelt = freeBelts * priceBelt;
			double neededMoney = (priceAllBelt - discountBelt) + priceAllRobe + priceAllLightsaber;

			if (money >= neededMoney)
			{
				Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
			}
			else
			{
				double neededxMoney = neededMoney - money;
				Console.WriteLine($"Ivan Cho will need { neededxMoney:F2}lv more.");
			}
		}
	}
}
