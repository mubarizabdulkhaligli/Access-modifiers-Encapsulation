using System;
namespace task2
{
	internal class Vehicle
	{
		protected double _mileage;

		public double Milage => _mileage;

		public virtual void Drive(double km)
		{
			_mileage += km;
		}
	}
}

