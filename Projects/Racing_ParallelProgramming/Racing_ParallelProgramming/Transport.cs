using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing_ParallelProgramming
{
    abstract class Transport : ITransport
    {
        protected string name;
        protected double speed; // speed in km/h
        protected double puncturePosibility;

        public virtual void DisplayParameters()
        {
            Console.WriteLine($"Information about {name}:");
            Console.WriteLine($"\tSpeed: {speed} km/h;");
            Console.WriteLine($"\tWheel puncture posibility: {puncturePosibility};");
        }

        public virtual void Move(double distanceInKm)
        {
            double speedInMSec = speed * 10 / 36;
            double distanceInM = distanceInKm * 1000;
            double distancePassed = 0;
            while (distanceInM > 0)
            {
                Thread.Sleep(1000);
                distanceInM -= speedInMSec;
                distancePassed += speedInMSec;
                Console.WriteLine($"{name} has passed {Math.Round(distancePassed / 1000, 3)}km");
            }
        }
    }
}
