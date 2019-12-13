using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Image
    {
        public int ID { get; set; }
        public int RestaurantId { get; set; }
        public string URL { get; set; }

        public Image()
        {

        }

        public Image(int id, int restaurantId, string url)
        {
            this.ID = id;
            this.RestaurantId = restaurantId;
            this.URL = url;
        }
    }
}
