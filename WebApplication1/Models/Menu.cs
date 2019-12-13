using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public int RestaurantId { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }


        public Menu()
        {

        }

        public Menu(int id, int restaurantId, ICollection<MenuItem> menuItems)
        {
            this.ID = id;
            this.RestaurantId = restaurantId;
            this.MenuItems = menuItems;
        }


        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

    }
}
