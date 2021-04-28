using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShopLib
{
    public delegate void FlowersOrderHandler(Flower flower, int amount);

    public class Florist
    {
        public string Name { get; private set; }
        public FlowerShop Workplace { get; set; }
        public event FlowersOrderHandler OnNotEnoughFlowersAvailable;

        public Florist(string name)
        {
            Name = name;
        }

        public Bunch CreateBunch(BunchBuilder builder)
        {
            if (AreNeededFlowersAvailable(builder))
            {
                builder.CreateBunch();
                builder.SetFlowers();
                builder.SetWrapping();
                builder.SetRibbon();
                builder.DisplayBuilderInfo();
            }

            return builder.Bunch;
        }

        private bool AreNeededFlowersAvailable(BunchBuilder builder)
        {
            foreach (var flowerAmount in builder.FlowersAmountMappings)
            {
                if (Workplace.AvailableFlowers.ContainsKey(flowerAmount.Key))
                {
                    if (Workplace.AvailableFlowers[flowerAmount.Key] < flowerAmount.Value)
                    {
                        Console.WriteLine($"There is not enough {flowerAmount.Key.Name} flowers to make a bunch");
                        Console.WriteLine($"\tAvailable amount {Workplace.AvailableFlowers[flowerAmount.Key]}");
                        Console.WriteLine($"\tNeeded amount {flowerAmount.Value}");
                        Console.WriteLine($"The needed amount will be ordered. Come back later and get your bunch!");

                        OnNotEnoughFlowersAvailable?.Invoke(flowerAmount.Key, flowerAmount.Value + 20);

                        return false;
                    }
                    else if (Workplace.AvailableFlowers[flowerAmount.Key] - flowerAmount.Value < 5)
                    {
                        Console.WriteLine($"We are running out of {flowerAmount.Key.Name}");
                        OnNotEnoughFlowersAvailable?.Invoke(flowerAmount.Key, 100);
                    }
                }
                else
                {
                    Console.WriteLine($"There is no {flowerAmount.Key.Name}({flowerAmount.Key.Height}cm, ${flowerAmount.Key.Price}) flowers in the shop!");
                }
            }

            return true;
        }
    }
}
