using System;
namespace task2
{
	internal class Car:Vehicle
	{
		
		public Car(double fuelCapacity)
		{
			this._fuelCapacity = fuelCapacity;
		}

		double _fuelCapacity;
		private double _currentFuel;

		public double CurrentFuel => _currentFuel;

		public double FuelCapacity
		{
			set
			{
				if (value >= 0 && CurrentFuel <= value)
					_fuelCapacity = value;
			}
			get => _fuelCapacity;
		} 

		public double FuelFor1km;

		public void AddFuel(double fuel)
		{
			if(_currentFuel+fuel<=FuelCapacity)
			_currentFuel += fuel;
		}

        public override void Drive(double km)
        {
			double neededFuel = FuelFor1km * km;
			if (_currentFuel >= neededFuel)
				_currentFuel -= neededFuel;
			_mileage += km;
        }
    }
}

