using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    class Vegetables : Product
    {
        public override double Cost { get => Price * Weight; }

        public Vegetables(string name, double price, double volume, double weight) : base(name, price, volume, weight)
        {
            TypeOfProduct = "Vegetable";
        }
    }
}
