using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    public class VegetablesCreator : ProductCreator
    {
        public override Product Create(string name, double price, double volume, double weight)
        {
            return new Vegetables(name, price, volume, weight);
        }
    }
}
