using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    class Fruits : Product
    {
        public override double Cost { get => Price * Weight; }

        public Fruits(string name, double price, double volume, double weight) : base(name, price, volume, weight)
        {
            TypeOfProduct = "Fruits";
        }
    }
}
