using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    public class MeatCreator: ProductCreator
    {
        public override Product Create(string name, double price, double volume, double weight)
        {
            return new Meat(name, price, volume, weight);
        }
    }
}
