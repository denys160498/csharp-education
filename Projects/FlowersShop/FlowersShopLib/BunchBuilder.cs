using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public abstract class BunchBuilder
    {
        public Bunch Bunch { get; private set; }
        public Dictionary<Flower, int> FlowersAmountMappings { get; protected set; }

        public void CreateBunch()
        {
            Bunch = new Bunch();
        }

        public virtual void SetFlowers()
        {
            Bunch.Flowers = new List<Flower>();

            foreach (var flowerMapping in FlowersAmountMappings)
            {
                for (int i = 0; i < flowerMapping.Value; i++)
                {
                    Bunch.Flowers.Add((Flower)flowerMapping.Key.Clone());
                }
            }
        }

        public virtual void DisplayBuilderInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Bunch was created!");
            Bunch.Display();
            Console.WriteLine("---------------------");
        }

        public abstract void SetWrapping();
        public abstract void SetRibbon();

    }
}
