using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    class Meat : Product
    {
        public override double Cost { get => Price * Weight; }

        public Meat(string name, double price, double volume, double weight) : base(name, price, volume, weight)
        {
            TypeOfProduct = "Meat";
        }
    }
}
