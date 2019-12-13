using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WebApplication1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Setting Settings { get; set; }
        public List<UserRestaurant> UserRestaurants { get; set; }
        public string Location { get; set; }

        public User()
        {

        }

        public User(int id, string username, string password, Setting settings, string location)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Settings = settings;
            this.Location = location;
        }

        public void ChangeLocation(string location)
        {
            Location.Replace(Location, location);
        }
    }
}
