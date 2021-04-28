using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public class HappyBirthdayBunchBuilder : BunchBuilder
    {
        public HappyBirthdayBunchBuilder()
        {
            FlowersAmountMappings = new Dictionary<Flower, int>()
            {
                [new Flower("Tulip", 30, 40)] = 31
            };
        }

        public override void SetRibbon()
        {
            Bunch.Rib = new Ribbon("HB ribbon");
        }

        public override void SetWrapping()
        {
            Bunch.Wrapping = new Wrap("HB wrapping");
        }

        public override void DisplayBuilderInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Happy Birthday Bunch was created!");
            Bunch.Display();
            Console.WriteLine("---------------------");
        }
    }
}
