using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Setting
    {
        public int ID { get; set; }
        public int Distance { get; set; }
        public int UserId { get; set; }
        public List<SettingKitchenType> SettingKitchenTypes { get; set; }
        public List<SettingPriceclass> SettingPriceclasses { get; set; }

        public Setting()
        {

        }

        public Setting(int id, List<SettingPriceclass> settingPriceclasses, List<SettingKitchenType> settingKitchenType, int distance, int userId)
        {
            this.ID = id;
            this.SettingPriceclasses = settingPriceclasses;
            this.Distance = distance;
            this.UserId = userId;
            this.SettingKitchenTypes = settingKitchenType;
        }
    }
}
