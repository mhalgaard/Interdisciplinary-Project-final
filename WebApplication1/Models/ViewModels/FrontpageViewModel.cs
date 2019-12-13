using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class FrontpageViewModel
    {
        public List<Restaurant> Restaurants { get; set; }
        public string UserCityName { get; set; }

    }
}
