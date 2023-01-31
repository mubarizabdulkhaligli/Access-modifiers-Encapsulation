using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Drive(10);
            vehicle.Drive(20);

            Console.WriteLine(vehicle.Milage);

            Car car = new Car(55);

            car.AddFuel(20);
            car.AddFuel(10);

            car.FuelFor1km = 0.1;

            car.Drive(30);
            car.Drive(10);

            
            

            Console.WriteLine($"Fuel Capacity: {car.FuelCapacity}");
            Console.WriteLine($"Current Fuel: {car.CurrentFuel}");
            Console.WriteLine($"Mileage: {car.Milage}");
        }
    }
}

