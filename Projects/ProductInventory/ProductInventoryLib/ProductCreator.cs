using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    abstract public class ProductCreator
    {
        abstract public Product Create(string name, double price, double volume, double weight);
    }
}
