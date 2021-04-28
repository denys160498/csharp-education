using System;

namespace FlowersShopLib
{
    //IEquatable<Flower> is to be able to use Flower as a key un Dictionary
    public class Flower: ICloneable, IEquatable<Flower>
    {
        private int Id;
        public string Name { get; private set; }
        public double Height { get; private set; }
        public double Price { get; private set; }

        public Flower(string name, double height, double price)
        {
            Id = (int)height * (int)price * name.Length;
            Name = name;
            Height = height;
            Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Equals(Flower other)
        {
            return other != null && other.Name == this.Name && other.Height == this.Height && other.Price == this.Price;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Flower);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
