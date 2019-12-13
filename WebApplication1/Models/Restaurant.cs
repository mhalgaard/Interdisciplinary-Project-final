using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priceclass { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public string Phonenumber { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Image> Images { get; set; }


        public List<RestaurantKitchenType> RestaurantKitchenTypes { get; set; }
        public List<RestaurantBadge> RestaurantBadges { get; set; }
        public List<UserRestaurant> UserRestaurants { get; set; }
        

        public Restaurant()
        {

        }

        public Restaurant(string name, string description, string priceclass, string address, string phonenumber, int id, int zipcode, List<RestaurantBadge> restaurantBadges, List<RestaurantKitchenType> restaurantKitchenTypes)
        {
            this.Name = name;
            this.Description = description;
            this.Priceclass = priceclass;
            this.Address = address;
            this.Phonenumber = phonenumber;
            this.ID = id;
            this.Zipcode = zipcode;
            this.RestaurantBadges = restaurantBadges;
            this.RestaurantKitchenTypes = restaurantKitchenTypes;
        }
    }
}
