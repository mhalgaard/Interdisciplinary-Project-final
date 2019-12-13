using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Badge
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public List<RestaurantBadge> RestaurantBadges { get; set; }

        public Badge()
        {

        }

        public Badge(int id, string name, string imageURL, List<RestaurantBadge> restaurants)
        {
            this.ID = id;
            this.Name = name;
            this.ImageURL = imageURL;
            this.RestaurantBadges = restaurants;
        }
    }
}
