using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public class Bunch
    {
        public List<Flower> Flowers { get; set; }
        public Wrap Wrapping { get; set; }
        public Ribbon Rib { get; set; }
        public double Cost 
        {
            get 
            {
                double sum = 0;
                foreach (Flower flower in Flowers)
                {
                    sum += flower.Price;
                }
                return sum;
            }
        }

        public Bunch()
        { }

        public Bunch(List<Flower> flowers, Wrap wrapping, Ribbon ribbon)
        {
            Flowers = flowers;
            Wrapping = wrapping;
            Rib = ribbon;
        }

        public void Display()
        {
            Console.WriteLine("Bunch info:");
            Console.WriteLine($"\tFlowers amount: {Flowers.Count};");
            Console.WriteLine($"\tWrapping: {Wrapping.Name};");
            Console.WriteLine($"\tRibbon: {Rib.Name};");
            Console.WriteLine($"\tCost: ${Cost};");
        }
    }
}
