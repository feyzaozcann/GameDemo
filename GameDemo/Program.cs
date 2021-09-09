using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer1 = new Gamer {Id="10916983434" , FirstName ="Feyza" , LastName ="Özcan", DateOfBirth = new DateTime (2001,2,1) };
            Gamer gamer2 = new Gamer {Id="213545", FirstName="Furkan", LastName="Özcan" , DateOfBirth=new DateTime(2004,12,21) };
            
            
            GamerManager gamerManager = new GamerManager();
            List<Gamer> gamers = new List<Gamer> { gamer1, gamer2 };
            foreach (var gamer in gamers)
            {
                gamerManager.Add(gamer);
            }

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { CampaignNumber = 2, DiscountRate = 0.20M };
            Campaign campaign2 = new Campaign { CampaignNumber = 5 , DiscountRate = 0.80M };
            List<Campaign> campaigns = new List<Campaign> { campaign1 , campaign2 };
            foreach (var campaign in campaigns)
            {
                campaignManager.Add(campaign);
            }

            GameManager gameManager = new GameManager();
            Game game1 = new Game {GameNumber = 7, GameCategory ="Car Racing" , GameName ="Need For Speed" , GamePrice ="200" };
            Game game2 = new Game { GameNumber = 6, GameCategory="Football" , GameName ="FIFA 2021" , GamePrice ="300" };

            gameManager.Add(game2);
            gameManager.Delete(game1);


            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            gamerCheckManager.Check(gamer1);




            Console.ReadLine();
        }
    }
}
