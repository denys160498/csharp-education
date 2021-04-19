using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryLib
{
    public delegate void DisplayProductHandler(Product product);
    public class Inventory
    {
        private List<Product> products;
        private double TotalCost
        {
            get { return ComputeTotalCost(); }
        }

        public Inventory()
        {
            products = new List<Product>();
        }

        private double ComputeTotalCost()
        {
            double sum = 0;

            foreach (Product prod in this)
            {
                sum += prod.Cost;
            }

            return sum;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        public void Display(DisplayProductHandler displayHandler)
        {
            Console.WriteLine($"Inventory contains {products.Count} products:");

            foreach (Product product in this)
            {
                displayHandler(product);
            }

            Console.WriteLine($"Total cost of all products is ${TotalCost}.");
        }

        public void Add(Product prod)
        {
            products.Add(prod);
        }

        public void Remove(Product prod)
        {
            products.Remove(prod);
        }
    }
}
