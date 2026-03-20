using System;

namespace VehicleManagementSystem.Models
{
    public class ElectricCar : Vehicle
    {
        private double batteryLevel;

        public double BatteryLevel
        {
            get => batteryLevel;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Battery must be 0–100%");
                batteryLevel = value;
            }
        }

        public override void Start()
        {
            if (BatteryLevel > 0)
            {
                IsRunning = true;
                Console.WriteLine($"{Make} {Model} started.");
            }
            else
            {
                Console.WriteLine("Cannot start - battery dead!");
            }
        }

        public override void Stop()
        {
            IsRunning = false;
            Console.WriteLine($"{Make} {Model} stopped.");
        }

        public void Charge(double amount)
        {
            BatteryLevel += amount;
            Console.WriteLine($"Charged. Battery level: {BatteryLevel}%");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electric Car: {Year} {Make} {Model}, Price: ${Price}");
        }
    }
}