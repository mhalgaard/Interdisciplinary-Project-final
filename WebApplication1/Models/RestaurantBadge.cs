using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RestaurantBadge
    {
        public int RestaurantId { get; set; }
        public int BadgeId { get; set; }
        public Badge Badge { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}