using System;
using System.Collections.Generic;
using System.Text;

namespace Racing_ParallelProgramming
{
    class Car : Transport
    {
        private static int carsAmount = 0;
        private int passengersAmount;

        public Car(double speed, int passAm)
        {
            carsAmount++;
            Name = $"Car{carsAmount}";
            puncturePosibility = 0.1;
            this.speed = speed;
            passengersAmount = passAm;
        }

        public override void DisplayParameters()
        {
            base.DisplayParameters();
            Console.WriteLine($"\tThere {(passengersAmount > 1 ? "are" : "is")} {passengersAmount} {(passengersAmount > 1 ? "passengers" : "passenger")} aboard;");
        }
    }
}
