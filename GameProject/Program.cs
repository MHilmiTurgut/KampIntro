
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
             Gamer gamer = new Gamer() { Id = 1, BirthYear = 1985, FirstName = "Hilmi", LastName = "Turgut", IdentityNumber = 12345 };
             GamerManager gamerManager = new GamerManager(new UserValidationManager());

             gamerManager.Add(gamer);

            //GamerManager gamerManager = new GamerManager(new UserValidationManager());

            //gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Hilmi", LastName = "Turgut", IdentityNumber = 12345 });

            Campaign campaign = new Campaign() { Id = 1, CampaignName = "Korona için EVDEKAL indirimi", CampaignDiscount = 50 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Game game = new Game()
            {
                Id = 1,
                GameName = "CyperPunk 2077",
                GamePrice = 300,
            };
            SaleManager saleManager = new SaleManager();
            saleManager.CampaignSale(gamer, game, campaign);


        }
    }
}
