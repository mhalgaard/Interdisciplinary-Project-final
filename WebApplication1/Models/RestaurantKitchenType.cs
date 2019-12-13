using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RestaurantKitchenType
    {
        public int RestaurantId { get; set; }
        public int KitchenTypeId { get; set; }
        public Restaurant Restaurant { get; set; }
        public KitchenType KitchenType { get; set; }
    }
}
