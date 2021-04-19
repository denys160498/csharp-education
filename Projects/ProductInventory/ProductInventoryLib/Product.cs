using System;

namespace ProductInventoryLib
{
    abstract public class Product
    {
        protected int id;
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public abstract double Cost { get; }
        public double Volume { get; protected set; }
        public double Weight { get; protected set; }
        public string TypeOfProduct { get; protected set; }

        public Product (string name, double price, double volume, double weight)
        {
            Name = name;
            Price = price;
            Volume = volume;
            Weight = weight;
        }
    }
}
