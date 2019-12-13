using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class EntityContext : DbContext
    {

        public EntityContext(DbContextOptions<EntityContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<RestaurantBadge> RestaurantBadges { get; set; }
        public DbSet<UserRestaurant> UserRestaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            modelBuilder.Entity<Restaurant>().ToTable("Restaurant");
            modelBuilder.Entity<Setting>().ToTable("Setting");
            modelBuilder.Entity<Badge>().ToTable("Badge");
            modelBuilder.Entity<KitchenType>().ToTable("KitchenType");
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<Priceclass>().ToTable("Priceclass");

            modelBuilder.Entity<RestaurantKitchenType>()
                .HasKey(kt => new { kt.RestaurantId, kt.KitchenTypeId });
            modelBuilder.Entity<RestaurantKitchenType>()
                .HasOne(kt => kt.Restaurant)
                .WithMany(r => r.RestaurantKitchenTypes)
                .HasForeignKey(kt => kt.RestaurantId);
            modelBuilder.Entity<RestaurantKitchenType>()
                .HasOne(kt => kt.KitchenType)
                .WithMany(r => r.RestaurantKitchenTypes)
                .HasForeignKey(kt => kt.KitchenTypeId);

            modelBuilder.Entity<RestaurantBadge>()
                .HasKey(b => new { b.RestaurantId, b.BadgeId });
            modelBuilder.Entity<RestaurantBadge>()
                .HasOne(b => b.Restaurant)
                .WithMany(r => r.RestaurantBadges)
                .HasForeignKey(b => b.RestaurantId);
            modelBuilder.Entity<RestaurantBadge>()
                .HasOne(b => b.Badge)
                .WithMany(r => r.RestaurantBadges)
                .HasForeignKey(b => b.BadgeId);

            modelBuilder.Entity<SettingKitchenType>()
                .HasKey(kt => new { kt.SettingId, kt.KitchenTypeId });
            modelBuilder.Entity<SettingKitchenType>()
                .HasOne(kt => kt.Setting)
                .WithMany(s => s.SettingKitchenTypes)
                .HasForeignKey(kt => kt.SettingId);
            modelBuilder.Entity<SettingKitchenType>()
                .HasOne(kt => kt.KitchenType)
                .WithMany(s => s.SettingKitchenTypes)
                .HasForeignKey(kt => kt.KitchenTypeId);

            modelBuilder.Entity<SettingPriceclass>()
                .HasKey(p => new { p.SettingId, p.PriceclassId });
            modelBuilder.Entity<SettingPriceclass>()
                .HasOne(p => p.Setting)
                .WithMany(s => s.SettingPriceclasses)
                .HasForeignKey(p => p.SettingId);
            modelBuilder.Entity<SettingPriceclass>()
                .HasOne(p => p.Priceclass)
                .WithMany(s => s.SettingPriceclasses)
                .HasForeignKey(p => p.PriceclassId);

            modelBuilder.Entity<UserRestaurant>()
                .HasKey(u => new { u.RestaurantId, u.UserId });
            modelBuilder.Entity<UserRestaurant>()
                .HasOne(u => u.Restaurant)
                .WithMany(r => r.UserRestaurants)
                .HasForeignKey(u => u.RestaurantId);
            modelBuilder.Entity<UserRestaurant>()
                .HasOne(u => u.User)
                .WithMany(r => r.UserRestaurants)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Username = "Admin",
                    Password = "Password",
                    Location = "Aarhus C"
                }
            );

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Name = "Cafe Smagløs",
                    Address = "Klostertorvet 7",
                    Zipcode = 8000,
                    Description = "Cafe Smagløs Aarhus C er en café med alt det, man forventer en cafe har. Brunch, burger, sandwich m.m. Der er tilmed en hyggelig stemning såvel ude som inde. Af og til har de bands til at komme og spille, så aftenen bliver en ekstra oplevelse. Sæt dig med en drink og nyd stemningen.",
                    ID = 1,
                    Phonenumber = "+45 123 456 78",
                    Priceclass = "$"
                },
                new Restaurant
                {
                    Name = "Restaurant Frederikshøj",
                    Address = "Oddervej 19-21",
                    Zipcode = 8000,
                    Description = "The cuisine of Frederikshøj is classic and modern, emancipated and unpredictable. A sophisticated union of the pure style of the nouvelle cuisine and the dizzying and complex deconstructions of the postmodern cuisine – with digressions to the detailed, slight minimalism and raw primordial forces of the new Nordic cuisine and the very advanced techniques and surprising compositions.",
                    ID = 2,
                    Phonenumber = "+45 234 567 89",
                    Priceclass = "$$$"
                },
                new Restaurant
                {
                    Name = "Memphis Roadhouse",
                    Address = "Christiansgade 32",
                    Zipcode = 8000,
                    Description = "“It doesn’t have to be fancy to be damm good!” That’s our humble creed here at Memphis Roadhouse.Using only the freshest local ingredients – prepared to the highest standard – we offer all the hospitality and soul of an authentic Southern barbeque joint.",
                    ID = 3,
                    Phonenumber = "+45 87 300 400",
                    Priceclass = "$$"
                },
                new Restaurant
                {
                    Name = "Restaurant Møf",
                    Address = "Vesterport 10",
                    Zipcode = 8000,
                    Description = "På Møf laver vi mad med en omhyggelighed, bevidsthed og respekt for de enkelte råvarer, der alle kommer til orde i vores tre forretter, tre hovedretter og tre desserter. Vores kærlighed til mad omfatter en konstant udvikling og en lyst til at eksperimentere. Derfor skifter vi menu hver måned, og vi er ikke blege for at få inspiration og plukke smage fra internationale køkkener, så længe det er i harmoni med den danske sæson.",
                    ID = 4,
                    Phonenumber = "+45 6173 3333",
                    Priceclass = "$$$"
                },
                new Restaurant
                {
                    Name = "Du er nået til vejs ende...",
                    ID = 5,
                    Priceclass = "Der er desværre ikke flere restauranter i dette område, udvid evt. distancen der søges indenfor på filtersiden."
                }
            );

            modelBuilder.Entity<KitchenType>().HasData(
                new KitchenType
                {
                    Name = "Dansk",
                    ID = 1
                },
                new KitchenType
                {
                    Name = "Cafémad",
                    ID = 2
                },
                new KitchenType
                {
                    Name = "Gourmet",
                    ID = 3
                },
                new KitchenType
                {
                    Name = "Lokalt",
                    ID = 4
                },
                new KitchenType
                {
                    Name = "Amerikansk",
                    ID = 5
                }
            );

            modelBuilder.Entity<Badge>().HasData(
                new Badge
                {
                    ID = 1,
                    ImageURL = "../img/vegetar.png",
                    Name = "Vegetarmærket"
                },
                new Badge
                {
                    ID = 2,
                    ImageURL = "../img/oekologi.png",
                    Name = "90-100% Økologimærket"
                },
                new Badge
                {
                    ID = 3,
                    ImageURL = "../img/elite.png",
                    Name = "Elitesmiley"
                }
            );

            modelBuilder.Entity<RestaurantBadge>().HasData(
                new RestaurantBadge 
                {
                    RestaurantId = 1,
                    BadgeId = 1
                },
                new RestaurantBadge
                {
                    RestaurantId = 1,
                    BadgeId = 2
                },
                new RestaurantBadge
                {
                    RestaurantId = 1,
                    BadgeId = 3
                },
                new RestaurantBadge
                {
                    RestaurantId = 2,
                    BadgeId = 3
                },
                new RestaurantBadge
                {
                    RestaurantId = 3,
                    BadgeId = 3
                },
                new RestaurantBadge
                {
                    RestaurantId = 4,
                    BadgeId = 3
                }

            );

            modelBuilder.Entity<RestaurantKitchenType>().HasData(
                new RestaurantKitchenType
                {
                    RestaurantId = 1,
                    KitchenTypeId = 1
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 1, 
                    KitchenTypeId = 2
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 2, 
                    KitchenTypeId = 3
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 2, 
                    KitchenTypeId = 4
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 2, 
                    KitchenTypeId = 1
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 3,
                    KitchenTypeId = 5
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 4,
                    KitchenTypeId = 4
                },
                new RestaurantKitchenType
                {
                    RestaurantId = 4,
                    KitchenTypeId = 3
                }
            );

            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    ID = 1,
                    RestaurantId = 1,
                },
                new Menu
                {
                    ID = 2,
                    RestaurantId = 2
                },
                new Menu
                {
                    ID = 3,
                    RestaurantId = 3
                },
                new Menu
                {
                    ID = 4,
                    RestaurantId = 4
                }
            );

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    ID = 1,
                    Title = "Stegt flæsk med persillesovs",
                    MenuId = 1,
                    Price = 50.99M, 
                    Categories = Categories.Forret
                },
                new MenuItem
                {
                    ID = 2, 
                    Title = "7 retters måltid",
                    MenuId = 2,
                    Price = 0M,
                    Categories = Categories.Courses
                },
                new MenuItem
                {
                    ID = 3,
                    Title = "10 retters måltid", 
                    MenuId = 2,
                    Price = 0M,
                    Categories = Categories.Courses
                },
                new MenuItem
                {
                    ID = 4,
                    Title = "Kansas City Big Rigs",
                    MenuId = 3,
                    Price = 149.00M,
                    Categories = Categories.Hovedret
                },
                new MenuItem
                {
                    ID = 5,
                    Title = "Beef Brisket",
                    MenuId = 3,
                    Price = 139.00M,
                    Categories = Categories.Hovedret
                },
                new MenuItem
                {
                    ID = 6,
                    Title = "Cookie Skillet",
                    MenuId = 3,
                    Price = 60.00M,
                    Categories = Categories.Dessert
                },
                new MenuItem
                {
                    ID = 7,
                    Title = "Let grillet fisk med hummer creme, silderogn, syltet græskar og havtorn",
                    MenuId = 4,
                    Price = 109.00M,
                    Categories = Categories.Hovedret
                },
                new MenuItem
                {
                    ID = 8,
                    Title = "3 franske råmælkeost med kompot og knækbrød",
                    MenuId = 4,
                    Price = 99.00M,
                    Categories = Categories.Dessert
                },
                new MenuItem
                {
                    ID = 9,
                    Title = "Club Sandwich",
                    MenuId = 1,
                    Price = 49.99M,
                    Categories = Categories.Frokost
                },
                new MenuItem
                {
                    ID = 10,
                    Title = "Coca Cola, 25cl",
                    MenuId = 2,
                    Price = 30.00M,
                    Categories = Categories.Drikkevare
                }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting
                {
                    ID = 1, 
                    Distance = 20,
                    UserId = 1
                }
            );

            modelBuilder.Entity<SettingKitchenType>().HasData(
                new SettingKitchenType
                {
                    SettingId = 1, 
                    KitchenTypeId = 1
                }
            );

            modelBuilder.Entity<SettingPriceclass>().HasData(
                new SettingPriceclass
                {
                    SettingId = 1,
                    PriceclassId = 1 
                }
            );

            modelBuilder.Entity<Priceclass>().HasData(
                new Priceclass
                {
                    ID = 1,
                    PriceclassValue = "$" 
                },
                new Priceclass
                {
                    ID = 2,
                    PriceclassValue = "$$" 
                },
                new Priceclass
                {
                    ID = 3,
                    PriceclassValue = "$$$" 
                }
            );

            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    ID = 1,
                    RestaurantId = 1, 
                    URL = "../img/cafe-smaglos.jpg"
                },
                new Image
                {
                    ID = 2,
                    RestaurantId = 2,
                    URL = "../img/frederikshoj.jpg"
                },
                new Image
                {
                    ID = 3,
                    RestaurantId = 3,
                    URL = "../img/memphisroadhouse.png"
                },
                new Image
                {
                    ID = 4,
                    RestaurantId = 4,
                    URL = "../img/restaurantmof.png"
                },
                new Image
                {
                    ID = 5,
                    RestaurantId = 5,
                    URL = "../img/End_of_the_road.jpg"
                }
            );

            modelBuilder.Entity<UserRestaurant>().HasData(
                new UserRestaurant
                {
                    UserId = 1, 
                    RestaurantId = 1
                },
                new UserRestaurant
                {
                    UserId = 1, 
                    RestaurantId = 2
                }
            );
        }
    }
}
