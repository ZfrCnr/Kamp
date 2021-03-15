using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public class BaseMarketManager : IMarketService
    {
        public void Buy(GameProducts product, User user)
        {
            Console.WriteLine("Satışı yapılan ürünler: \n  " + product.Name + " => Ürün Tutarı: " + product.Price + "\n ");
        }

        public void Return(GameProducts product, User user)
        {
            Console.WriteLine("İade edilen ürünler: \n " + product.Name + " => İade Tutarı: " + product.Price + "\n\n ");
        }
    }
}
