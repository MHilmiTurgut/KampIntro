using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        public void CampaignSale(Gamer gamer,Game game,Campaign campaign);
        public void GameSale(Gamer gamer, Game game);
    }
}
