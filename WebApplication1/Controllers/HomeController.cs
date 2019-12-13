using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly EntityContext _db;

        public HomeController(EntityContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            var vm = new FrontpageViewModel
            {
                Restaurants = _db.Restaurants
                .Include(x => x.Images)
                .Include(x => x.RestaurantKitchenTypes)
                    .ThenInclude(x => x.KitchenType)
                .Include(x => x.RestaurantBadges)
                    .ThenInclude(x => x.Badge)
                .Include(x => x.Menus)
                    .ThenInclude(x => x.MenuItems)
                .ToList(),

                UserCityName = _db.Users.Single(x => x.ID == 1).Location
            };

            ViewBag.isHomepage = true;

            return View(vm);

        }


        //[HttpPost]
        //public void SaveRestaurant([FromBody]int userId, [FromBody]int restaurantId)
        //{
        //    _db.UserRestaurants.Add(
        //        new Models.UserRestaurant
        //        {
        //            UserId = userId,
        //            RestaurantId = restaurantId
        //        }
        //    );

        //    _db.SaveChanges();
        //}
    }
}