using System;
using project1;
using project2;

namespace homework
{
	class Program
	{
		static void Main(string[] args)
		{
			Drink Whisky = new Drink();

			Whisky.Name = "Chivas Regal";
			Whisky.Price = 250;
			Whisky.AlcoholPercent = 40;

			Drink Cola = new Drink();
			Cola.Name = "Pepsi Cola 1l";
			Cola.Price = 2;
			Cola.AlcoholPercent = 0;

            Console.WriteLine($"Name: {Whisky.Name}\nPrice: {Whisky.Price}\nAlcohol Percent: {Whisky.AlcoholPercent}%");
            Console.WriteLine($"Name: {Cola.Name}\nPrice: {Cola.Price}\nAlcohol Percent: {Cola.AlcoholPercent}%");
            
		}
	}
}

