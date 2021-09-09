using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game :IEntity
    {
        public int GameNumber { get; set; }
        public string GameName { get; set; }
        public string GamePrice { get; set; }
        public string GameCategory { get; set; }


    }
}
