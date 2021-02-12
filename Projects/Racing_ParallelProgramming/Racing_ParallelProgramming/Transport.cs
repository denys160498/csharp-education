using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing_ParallelProgramming
{
    abstract class Transport : ITransport
    {
        public string Name { get; protected set; }
        protected double speed; // speed in km/h
        protected double puncturePosibility;

        public virtual void DisplayParameters()
        {
            Console.WriteLine($"Information about {Name}:");
            Console.WriteLine($"\tSpeed: {speed} km/h;");
            Console.WriteLine($"\tWheel puncture posibility: {puncturePosibility};");
        }

        public virtual double Move(double distanceInKm)
        {
            Stopwatch sw = new Stopwatch();
            double speedInMSec = speed * 10 / 36;
            double distanceInM = distanceInKm * 1000;
            double distancePassed = 0;

            sw.Start();
            while (distanceInM > 0)
            {
                Random rnd = new Random();
                Thread.Sleep(1000);

                if (rnd.NextDouble() < puncturePosibility)
                {
                    Console.WriteLine($"{Name} has punctured a tire! \nRepairing in progress");
                    Thread.Sleep(5000);
                }

                distanceInM -= speedInMSec;
                distancePassed += speedInMSec;
                Console.WriteLine($"{Name} has passed {Math.Round(distancePassed / 1000, 3)}km");
            }
            sw.Stop();

            return Math.Round(sw.ElapsedMilliseconds / 1000.0, 2);
        }
    }
}
