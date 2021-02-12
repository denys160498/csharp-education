using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Racing_ParallelProgramming
{
    class Track
    {
        private int circleId;
        private double length;
        private List<Transport> transportsOnTrack;
        private List<RaceResult> raceResults;

        internal Track(double length, List<Transport> transports)
        {
            this.length = length;
            transportsOnTrack = transports;
            circleId = 0;
            raceResults = new List<RaceResult>();
        }

        internal Task[] StartRace()
        {
            raceResults.Clear();
            circleId++;
            foreach (Transport transport in transportsOnTrack)
            {
                transport.DisplayParameters();
            }

            Task<double>[] tasks = new Task<double>[transportsOnTrack.Count];

            for(int i = 0; i < transportsOnTrack.Count; i++)
            {
                int index = i;
                tasks[index] = Task<double>.Run(() => { return transportsOnTrack[index].Move(length); });
                raceResults.Add(new RaceResult(transportsOnTrack[index].Name, tasks[index]));
            }

            return tasks;
        }

        internal void DisplayCircleResults()
        {
            int place = 0;
            raceResults.Sort();

            Console.WriteLine($"\n###Race result of {circleId} circle###");
            Console.WriteLine($"Place\tTransport Name\tTime of circle");

            foreach (RaceResult result in raceResults)
            {
                place++;
                Console.WriteLine($"{place, -5}\t{result.Name,-15}\t{result.CircleTime} s");
            }
            Console.WriteLine();
        }
    }

    struct RaceResult : IComparable
    {
        public string Name { get; }
        public double CircleTime
        {
            get
            {
                if (transportTask.IsCompleted)
                    return transportTask.Result;
                else
                    return 0.0;
            }
        }
        private Task<double> transportTask;

        public RaceResult(string name, Task<double> task)
        {
            Name = name;
            transportTask = task;
        }

        public int CompareTo(object obj)
        {
            if (this.CircleTime > ((RaceResult)obj).CircleTime)
            {
                return 1;
            }
            else if (this.CircleTime < ((RaceResult)obj).CircleTime)
            {
                return -1;
            }

            return 0;
        }
    }
}
