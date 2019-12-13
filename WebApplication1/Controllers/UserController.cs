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
    public class UserController : Controller
    {
        private readonly EntityContext _db;

        public UserController(EntityContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            var vm = new UserViewModel
            {
                Restaurants = _db.Restaurants
                .Include(x => x.Images)
                .Include(x => x.RestaurantKitchenTypes)
                    .ThenInclude(x => x.KitchenType)
                .Include(x => x.RestaurantBadges)
                    .ThenInclude(x => x.Badge)
                .Include(x => x.Menus)
                    .ThenInclude(x => x.MenuItems)
                .ToList()
            };

            return View(vm);
        }
    }
}