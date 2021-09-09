using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " added!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " deleted!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " updated!");
        }
    }
}
