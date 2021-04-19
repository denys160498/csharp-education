using System;
using ProductInventoryLib;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCreator prodCreator = new VegetablesCreator();
            Inventory inventory = new Inventory();

            inventory.Add(prodCreator.Create("Carrot", 12.5, 2, 2));
            inventory.Add(prodCreator.Create("Potato", 6.1, 4.1, 4.0));
            prodCreator = new FruitsCreator();
            inventory.Add(prodCreator.Create("Apple", 20, 12, 12.1));
            inventory.Add(prodCreator.Create("Pineapple", 70, 4.0, 4.0));
            prodCreator = new MeatCreator();
            inventory.Add(prodCreator.Create("Biff", 173, 2.0, 2.0));

            inventory.Display(DisplayProduct);
        }

        static void DisplayProduct(Product prod)
        {
            Console.WriteLine($"Product {prod.Name}");
            Console.WriteLine($"\tType: {prod.TypeOfProduct}");
            Console.WriteLine($"\tVolume: {prod.Volume} l");
            Console.WriteLine($"\tWeight: {prod.Weight} kg");
            Console.WriteLine($"\tPrice: ${prod.Price}");
            Console.WriteLine($"\tCost: ${prod.Cost}");
        }
    }
}
