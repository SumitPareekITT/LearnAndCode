using System;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services;

namespace VehicleManagementSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Vehicle Management Demo ===\n");

            var car = new Car
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2023,
                Price = 28000,
                FuelLevel = 100
            };

            var motorcycle = new Motorcycle
            {
                Make = "Harley-Davidson",
                Model = "Street 750",
                Year = 2022,
                Price = 7500,
                FuelLevel = 80,
                HasSidecar = false
            };

            var electricCar = new ElectricCar
            {
                Make = "Tesla",
                Model = "Model 3",
                Year = 2023,
                Price = 42000,
                BatteryLevel = 100
            };

            var manager = new VehicleManager();

            manager.AddVehicle(car);
            manager.AddVehicle(motorcycle);
            manager.AddVehicle(electricCar);

            manager.DisplayAll();

            Console.WriteLine($"\nTotal Value: ${manager.CalculateTotalValue()}");

            Console.WriteLine("\nStarting all vehicles:");
            manager.StartAllVehicles();
        }
    }
}