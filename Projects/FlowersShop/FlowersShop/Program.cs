using System;
using FlowersShopLib;
using System.Collections.Generic;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Florist> florists = new List<Florist>() { new Florist("Vanya"), new Florist("Fedya") };
            Dictionary<Flower, int> flowers = new Dictionary<Flower, int>
            {
                [new Flower("Tulip", 30, 40)] = 35,
                [new Flower("Rose", 50, 60)] = 40,
                [new Flower("Chrysanthemum", 40, 15)] = 100,
                [new Flower("Chamomile", 20, 10)] = 20,

            };

            FlowerShop flowerShop = new FlowerShop(florists,flowers);

            flowerShop.Florists[0].CreateBunch(new HappyBirthdayBunchBuilder());
            flowerShop.Florists[1].CreateBunch(new WeddingBunchBuilder());

            flowerShop.Florists[0].CreateBunch(new CustomBunchBuilder(new Dictionary<Flower, int> { [new Flower("Chrysanthemum", 40, 15)] = 15 }, new Ribbon("CustomRibbon1"), new Wrap("CustomWrap1")));
            flowerShop.Florists[1].CreateBunch(new CustomBunchBuilder(new Dictionary<Flower, int> { [new Flower("Carnation", 40, 15)] = 21 }, new Ribbon("CustomRibbon2"), new Wrap("CustomWrap2")));
        }
    }
}
