using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MenuItem
    {
        public string Title { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        public int MenuId { get; set; }
        public int ID { get; set; }
        public Categories Categories { get; set; }

        public MenuItem()
        {

        }

        public MenuItem(string title, decimal price, Categories category, int menuId, int id)
        {
            this.ID = id;
            this.Title = title;
            this.Price = price;
            this.Categories = category;
            this.MenuId = menuId;
        }
    }
    public enum Categories { Forret, Hovedret, Dessert, Drikkevare, Courses, Frokost }
}
