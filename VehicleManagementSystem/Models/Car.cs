using System;

namespace VehicleManagementSystem.Models
{
    public class Car : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel
        {
            get => fuelLevel;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Fuel must be 0–100%");
                fuelLevel = value;
            }
        }

        public override void Start()
        {
            if (FuelLevel > 0)
            {
                IsRunning = true;
                Console.WriteLine($"{Make} {Model} started.");
            }
            else
            {
                Console.WriteLine("Cannot start - no fuel!");
            }
        }

        public override void Stop()
        {
            IsRunning = false;
            Console.WriteLine($"{Make} {Model} stopped.");
        }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            Console.WriteLine($"Refueled. Fuel level: {FuelLevel}%");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}, Price: ${Price}");
        }
    }
}