using System;

namespace project1
{
	public class Product
	{
		protected string _name;
		protected double _price;

		public double Price {
			set
			{
				if (value > 0)
					_price = value;
			}
			get => _price;
		}

		public string Name {
			set
			{
				if (value.Length >= 2 && value.Length <= 20)
					_name = value;
			}
			get => _name;
			}
	}
}

