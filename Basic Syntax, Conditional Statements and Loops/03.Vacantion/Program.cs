using System;

namespace _03.Vacantion
{
	class Program
	{
		static void Main(string[] args)
		{
			int people = int.Parse(Console.ReadLine());
			string type = Console.ReadLine();
			string day = Console.ReadLine();
			double money = 1;
			double price = 1;

			switch (day)
			{
				case "Friday":

					if (type == "Students")
					{
						price = 8.45;

						if (people >= 30)
						{
							money = (price * people) - ((price * people) * 0.15);
						}
						else
						{
							money = price * people;
						}
					}

					if (type == "Business")
					{
						price = 10.90;

						if (people >= 100)
						{
							people = people - 10;
							money = price * people;
						}

						else
						{
							money = price * people;
						}
					}

					if (type == "Regular")
					{
						price = 15;

						if (people >= 10 && people <= 20)
						{
							money = (price * people) - (price * people * 0.05);
						}
						else
						{
							money = price * people;
						}
					}
					break;
				case "Saturday":

					if (type == "Students")
					{
						price = 9.80;

						if (people >= 30)
						{
							money = (price * people) - ((price * people) * 0.15);
						}
						else
						{
							money = price * people;
						}
					}

					if (type == "Business")
					{
						price = 15.60;

						if (people >= 100)
						{
							people = people - 10;
							money = price * people;
						}
						else
						{
							money = price * people;
						}
					}

					if (type == "Regular")
					{
						price = 20.00;

						if (people >= 10 && people <= 20)
						{
							money = (price * people) - (price * people * 0.05);
						}
						else
						{
							money = price * people;
						}
					}
					break;
				case "Sunday":

					if (type == "Students")
					{
						price = 10.46;

						if (people >= 30)
						{
							money = (price * people) - ((price * people) * 0.15);
						}
						else
						{
							money = price * people;
						}
					}

					if (type == "Business")
					{
						price = 16;

						if (people >= 100)
						{
							people = people - 10;
							money = price * people;
						}
						else
						{
							money = price * people;
						}
					}

					if (type == "Regular")
					{
						price = 22.50;

						if (people >= 10 && people <= 20)
						{
							money = (price * people) - (price * people * 0.05);
						}
						else
						{
							money = price * people;
						}
					}

					break;
				default:
					Console.WriteLine("Invalid data");
					break;
			}

			Console.WriteLine($"Total price: {money:F2}");
		}
	}
}
