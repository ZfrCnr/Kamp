using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign, GameProducts product)
        {
            Console.WriteLine("'" + campaign.Campaign + "' kampanyası \n'" + product.Name + "' ürününe başarıyla eklendi.");
        }

        public void Update(Campaigns campaign, GameProducts product)
        {
            Console.WriteLine("'" + campaign.Campaign + "' kampanyası \n'" + product.Name + "' ürününde başarıyla güncellendi.");
        }

        public void Delete(Campaigns campaign, GameProducts product)
        {
            Console.WriteLine("'" + campaign.Campaign + "' kampanyası \n'" + product.Name + "' ürününden başarıyla kaldırıldı.");
        }
    }
}
