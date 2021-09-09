using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {

        //IGamerCheckService _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            return true;
            //_gamerCheckService = new MernisServiceAdapter();
            //return _gamerCheckService.Check(gamer);
        }
    }
}
