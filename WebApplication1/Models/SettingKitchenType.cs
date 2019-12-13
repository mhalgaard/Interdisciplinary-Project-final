using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SettingKitchenType
    {
        public int SettingId { get; set; }
        public int KitchenTypeId { get; set; }
        public KitchenType KitchenType { get; set; }
        public Setting Setting { get; set; }
    }
}
