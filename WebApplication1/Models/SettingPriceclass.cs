using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SettingPriceclass
    {
        public int SettingId { get; set; }
        public int PriceclassId { get; set; }
        public Setting Setting { get; set; }
        public Priceclass Priceclass { get; set; }
    }
}
