using System;
using System.Collections.Generic;
using System.Text;

namespace Racing_ParallelProgramming
{
    class Truck: Transport
    {
        private static int trucksAmount = 0;
        private double cargoMass;

        public Truck(double speed, double cargo)
        {
            trucksAmount++;
            Name = $"Truck{trucksAmount}";
            puncturePosibility = 0.05;
            this.speed = speed;
            cargoMass = cargo;
        }

        public override void DisplayParameters()
        {
            base.DisplayParameters();
            Console.WriteLine($"\tCargo`s weight is {cargoMass}kg");
        }
    }
}
