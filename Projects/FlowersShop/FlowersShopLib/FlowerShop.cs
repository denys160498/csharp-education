using System;
using System.Collections.Generic;
using System.Threading;

namespace FlowersShopLib
{
    public class FlowerShop
    {
        public List<Florist> Florists { get; private set; }
        public Dictionary<Flower, int> AvailableFlowers { get; set; }
        public static object locker = new object();


        public FlowerShop(List<Florist> florists, Dictionary<Flower, int> availablesFlowers)
        {
            Florists = florists;
            foreach (Florist florist in Florists)
            {
                florist.Workplace = this;
                florist.OnNotEnoughFlowersAvailable += ThreadedFlowersOrder;
            }

            AvailableFlowers = availablesFlowers;
        }

        private void ThreadedFlowersOrder(Flower flower, int amount)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(OrderFlowers));
            thread.Start(new Tuple<Flower, int>(flower, amount));
        }

        private void OrderFlowers(object obj)
        {
            Tuple<Flower, int> parameters = (Tuple<Flower, int>) obj;
            Console.WriteLine($"Ordering {parameters.Item2} {parameters.Item1.Name} flowers...");
            lock (locker)
            {
                AvailableFlowers[parameters.Item1] += parameters.Item2;
            }
            Thread.Sleep(300);
            Console.WriteLine($"{parameters.Item2} {parameters.Item1.Name} flowers are ordered");
        }

        
    }
}
