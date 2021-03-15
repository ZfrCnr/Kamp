using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface IMarketService
    {
        void Buy(GameProducts product, User user);
        void Return(GameProducts product, User user);
    }
}
