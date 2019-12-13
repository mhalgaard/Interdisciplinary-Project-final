using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class KitchenType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<RestaurantKitchenType> RestaurantKitchenTypes { get; set; }
        public List<SettingKitchenType> SettingKitchenTypes { get; set; }

        public KitchenType()
        {

        }

        public KitchenType(int id, string name, List<RestaurantKitchenType> restaurantKitchenTypes)
        {
            this.ID = id;
            this.Name = name;
            this.RestaurantKitchenTypes = restaurantKitchenTypes;
        }
    }
}
