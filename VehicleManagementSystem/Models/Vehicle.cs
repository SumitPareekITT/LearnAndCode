using System;

namespace VehicleManagementSystem.Models
{
    public abstract class Vehicle
    {
        private double price;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0 || value > 1_000_000)
                    throw new ArgumentException("Invalid price");
                price = value;
            }
        }

        public bool IsRunning { get; protected set; }

        public abstract void Start();
        public abstract void Stop();
        public abstract void DisplayInfo();
    }
}