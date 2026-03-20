using System;
using System.Collections.Generic;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Services
{
    public class VehicleManager
    {
        private readonly List<Vehicle> vehicles = new();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"{vehicle.GetType().Name} added");
        }

        public void DisplayAll()
        {
            Console.WriteLine("\n=== Vehicles ===");
            foreach (var v in vehicles)
                v.DisplayInfo();
        }

        public double CalculateTotalValue()
        {
            double total = 0;
            foreach (var v in vehicles)
                total += v.Price;
            return total;
        }

        public void StartAllVehicles()
        {
            foreach (var v in vehicles)
                v.Start();
        }
    }
}