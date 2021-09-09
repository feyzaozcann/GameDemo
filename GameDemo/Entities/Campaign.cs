using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign :IEntity
    {
        public int CampaignNumber { get; set; }
        public decimal DiscountRate { get; set; }

    }
}
