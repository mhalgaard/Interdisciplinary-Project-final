using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Priceclass
    {
        public int ID { get; set; }
        public string PriceclassValue { get; set; }
        public List<SettingPriceclass> SettingPriceclasses { get; set; }

        public Priceclass()
        {

        }

        public Priceclass(int id, string priceclassValue)
        {
            this.ID = id;
            this.PriceclassValue = priceclassValue;
        }
    }
}
