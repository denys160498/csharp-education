using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Racing_ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(60, 4);
            Truck truck = new Truck(50, 100.5);
            Motocycle motocycle = new Motocycle(70, false);

            Track track = new Track(0.5, new List<Transport> { car, truck, motocycle });

            Task.WaitAll(track.StartRace());
            Console.WriteLine("End of main");
        }
    }
}
