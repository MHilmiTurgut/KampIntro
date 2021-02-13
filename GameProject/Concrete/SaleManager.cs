using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + campaign.CampaignName + " kampanyası ile %" + campaign.CampaignDiscount +" inirim ile " + gamer.FirstName + "adlı oyuncuya satıldı...");
        }

        public void GameSale(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + "adlı oyuncuya satıldı...");
        }

        internal void CampaignSale(object gamer, Game game, Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
