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
            Track track = new Track(0.1, new List<Transport> { car, truck, motocycle });
            
            while (true)
            {
                Console.WriteLine("Do you want to race?(y/n):");
                string response = Console.ReadLine();

                switch(response.ToLower())
                {
                    case "y":
                        Task.WaitAll(track.StartRace());
                        track.DisplayCircleResults();
                        continue;
                    case "n":
                        break;
                    default:
                        Console.WriteLine("Wrong response!");
                        continue;
                }
                break;
            }
            Console.WriteLine("End of main");
        }
    }
}
