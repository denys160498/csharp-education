using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public class CustomBunchBuilder : BunchBuilder
    {
        private Ribbon ribbon;
        private Wrap wrapping;

        public CustomBunchBuilder(Dictionary<Flower, int> flowersMapping, Ribbon rib, Wrap wrap)
        {
            FlowersAmountMappings = flowersMapping;
            ribbon = rib;
            wrapping = wrap;
        }

        public override void SetRibbon()
        {
            Bunch.Rib = ribbon;
        }

        public override void SetWrapping()
        {
            Bunch.Wrapping = wrapping;
        }
    }
}
