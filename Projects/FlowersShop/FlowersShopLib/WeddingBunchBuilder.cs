using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public class WeddingBunchBuilder: BunchBuilder
    {
        public WeddingBunchBuilder()
        {
            FlowersAmountMappings = new Dictionary<Flower, int>()
            {
                [new Flower("Rose", 50, 60)] = 31
            };
        }

        public override void SetRibbon()
        {
            Bunch.Rib = new Ribbon("Wedding ribbon");
        }

        public override void SetWrapping()
        {
            Bunch.Wrapping = new Wrap("Wedding wrapping");
        }

        public override void DisplayBuilderInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Wedding Bunch was created!");
            Bunch.Display();
            Console.WriteLine("---------------------");
        }
    }
}
