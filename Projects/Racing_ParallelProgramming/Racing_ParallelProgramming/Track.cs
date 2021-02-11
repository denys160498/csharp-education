using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Racing_ParallelProgramming
{
    class Track
    {
        internal double length;
        internal List<Transport> transportsOnTrack;

        internal Track(double length, List<Transport> transports)
        {
            this.length = length;
            transportsOnTrack = transports;
        }

        internal Task[] StartRace()
        {
            foreach (Transport transport in transportsOnTrack)
            {
                transport.DisplayParameters();
            }

            Task[] tasks = new Task[transportsOnTrack.Count];

            for(int i = 0; i < transportsOnTrack.Count; i++)
            {
                int index = i;
                tasks[index] = Task.Run(() => transportsOnTrack[index].Move(length));
            }

            return tasks;
        }
    }
}
