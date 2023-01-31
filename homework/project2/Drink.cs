using System;
using project1;

namespace project2
{
	public class Drink:Product
	{
		private double _alcoholPercent;

		public double AlcoholPercent {
			set
			{
				if (value >= 0 && value <= 100)
					_alcoholPercent = value;
			}
			get => _alcoholPercent;
		}
	}
}

