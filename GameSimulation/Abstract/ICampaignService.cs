using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign, GameProducts product);
        void Update(Campaigns campaign, GameProducts product);
        void Delete(Campaigns campaign, GameProducts product);
    }
}
