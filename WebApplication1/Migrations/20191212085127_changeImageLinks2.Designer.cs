﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20191212085127_changeImageLinks2")]
    partial class changeImageLinks2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Badge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Badge");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ImageURL = "../img/vegetar.png",
                            Name = "Vegetarmærket"
                        },
                        new
                        {
                            ID = 2,
                            ImageURL = "../img/oekologi.png",
                            Name = "90-100% Økologimærket"
                        },
                        new
                        {
                            ID = 3,
                            ImageURL = "../img/elite.png",
                            Name = "Elitesmiley"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            RestaurantId = 1,
                            URL = "../img/cafe-smaglos.jpg"
                        },
                        new
                        {
                            ID = 2,
                            RestaurantId = 2,
                            URL = "../img/frederikshoj.jpg"
                        },
                        new
                        {
                            ID = 3,
                            RestaurantId = 3,
                            URL = "../img/memphisroadhouse.png"
                        },
                        new
                        {
                            ID = 4,
                            RestaurantId = 4,
                            URL = "../img/restaurantmof.png"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.KitchenType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KitchenType");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Dansk"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Cafémad"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Gourmet"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Lokalt"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Amerikansk"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            RestaurantId = 1
                        },
                        new
                        {
                            ID = 2,
                            RestaurantId = 2
                        },
                        new
                        {
                            ID = 3,
                            RestaurantId = 3
                        },
                        new
                        {
                            ID = 4,
                            RestaurantId = 4
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.MenuItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categories")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Categories = 0,
                            MenuId = 1,
                            Price = 50.99m,
                            Title = "Stegt flæsk med persillesovs"
                        },
                        new
                        {
                            ID = 2,
                            Categories = 4,
                            MenuId = 2,
                            Price = 0m,
                            Title = "7 retters måltid"
                        },
                        new
                        {
                            ID = 3,
                            Categories = 4,
                            MenuId = 2,
                            Price = 0m,
                            Title = "10 retters måltid"
                        },
                        new
                        {
                            ID = 4,
                            Categories = 1,
                            MenuId = 3,
                            Price = 149.00m,
                            Title = "Kansas City Big Rigs"
                        },
                        new
                        {
                            ID = 5,
                            Categories = 1,
                            MenuId = 3,
                            Price = 139.00m,
                            Title = "Beef Brisket"
                        },
                        new
                        {
                            ID = 6,
                            Categories = 2,
                            MenuId = 3,
                            Price = 60.00m,
                            Title = "Cookie Skillet"
                        },
                        new
                        {
                            ID = 7,
                            Categories = 1,
                            MenuId = 4,
                            Price = 109.00m,
                            Title = "Let grillet fisk med hummer creme, silderogn, syltet græskar og havtorn"
                        },
                        new
                        {
                            ID = 8,
                            Categories = 2,
                            MenuId = 4,
                            Price = 99.00m,
                            Title = "3 franske råmælkeost med kompot og knækbrød"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Priceclass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PriceclassValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Priceclass");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            PriceclassValue = "$"
                        },
                        new
                        {
                            ID = 2,
                            PriceclassValue = "$$"
                        },
                        new
                        {
                            ID = 3,
                            PriceclassValue = "$$$"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priceclass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Restaurant");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Klostertorvet 7",
                            Description = "Cafe Smagløs Aarhus C er en café med alt det, man forventer en cafe har. Brunch, burger, sandwich m.m. Der er tilmed en hyggelig stemning såvel ude som inde. Af og til har de bands til at komme og spille, så aftenen bliver en ekstra oplevelse. Sæt dig med en drink og nyd stemningen.",
                            Name = "Cafe Smagløs",
                            Phonenumber = "+45 123 456 78",
                            Priceclass = "$",
                            Zipcode = 8000
                        },
                        new
                        {
                            ID = 2,
                            Address = "Oddervej 19-21",
                            Description = "The cuisine of Frederikshøj is classic and modern, emancipated and unpredictable. A sophisticated union of the pure style of the nouvelle cuisine and the dizzying and complex deconstructions of the postmodern cuisine – with digressions to the detailed, slight minimalism and raw primordial forces of the new Nordic cuisine and the very advanced techniques and surprising compositions.",
                            Name = "Restaurant Frederikshøj",
                            Phonenumber = "+45 234 567 89",
                            Priceclass = "$$$",
                            Zipcode = 8000
                        },
                        new
                        {
                            ID = 3,
                            Address = "Christiansgade 32",
                            Description = "“It doesn’t have to be fancy to be damm good!” That’s our humble creed here at Memphis Roadhouse.Using only the freshest local ingredients – prepared to the highest standard – we offer all the hospitality and soul of an authentic Southern barbeque joint.",
                            Name = "Memphis Roadhouse",
                            Phonenumber = "+45 87 300 400",
                            Priceclass = "$$",
                            Zipcode = 8000
                        },
                        new
                        {
                            ID = 4,
                            Address = "Vesterport 10",
                            Description = "På Møf laver vi mad med en omhyggelighed, bevidsthed og respekt for de enkelte råvarer, der alle kommer til orde i vores tre forretter, tre hovedretter og tre desserter. Vores kærlighed til mad omfatter en konstant udvikling og en lyst til at eksperimentere. Derfor skifter vi menu hver måned, og vi er ikke blege for at få inspiration og plukke smage fra internationale køkkener, så længe det er i harmoni med den danske sæson.",
                            Name = "Restaurant Møf",
                            Phonenumber = "+45 6173 3333",
                            Priceclass = "$$$",
                            Zipcode = 8000
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.RestaurantBadge", b =>
                {
                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("BadgeId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantId", "BadgeId");

                    b.HasIndex("BadgeId");

                    b.ToTable("RestaurantBadges");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            BadgeId = 1
                        },
                        new
                        {
                            RestaurantId = 1,
                            BadgeId = 2
                        },
                        new
                        {
                            RestaurantId = 1,
                            BadgeId = 3
                        },
                        new
                        {
                            RestaurantId = 2,
                            BadgeId = 3
                        },
                        new
                        {
                            RestaurantId = 3,
                            BadgeId = 3
                        },
                        new
                        {
                            RestaurantId = 4,
                            BadgeId = 3
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.RestaurantKitchenType", b =>
                {
                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("KitchenTypeId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantId", "KitchenTypeId");

                    b.HasIndex("KitchenTypeId");

                    b.ToTable("RestaurantKitchenType");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            KitchenTypeId = 1
                        },
                        new
                        {
                            RestaurantId = 1,
                            KitchenTypeId = 2
                        },
                        new
                        {
                            RestaurantId = 2,
                            KitchenTypeId = 3
                        },
                        new
                        {
                            RestaurantId = 2,
                            KitchenTypeId = 4
                        },
                        new
                        {
                            RestaurantId = 2,
                            KitchenTypeId = 1
                        },
                        new
                        {
                            RestaurantId = 3,
                            KitchenTypeId = 5
                        },
                        new
                        {
                            RestaurantId = 4,
                            KitchenTypeId = 4
                        },
                        new
                        {
                            RestaurantId = 4,
                            KitchenTypeId = 3
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Setting");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Distance = 20,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.SettingKitchenType", b =>
                {
                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.Property<int>("KitchenTypeId")
                        .HasColumnType("int");

                    b.HasKey("SettingId", "KitchenTypeId");

                    b.HasIndex("KitchenTypeId");

                    b.ToTable("SettingKitchenType");

                    b.HasData(
                        new
                        {
                            SettingId = 1,
                            KitchenTypeId = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.SettingPriceclass", b =>
                {
                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.Property<int>("PriceclassId")
                        .HasColumnType("int");

                    b.HasKey("SettingId", "PriceclassId");

                    b.HasIndex("PriceclassId");

                    b.ToTable("SettingPriceclass");

                    b.HasData(
                        new
                        {
                            SettingId = 1,
                            PriceclassId = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Location = "Aarhus C",
                            Password = "Password",
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.UserRestaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRestaurant");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            UserId = 1
                        },
                        new
                        {
                            RestaurantId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Image", b =>
                {
                    b.HasOne("WebApplication1.Models.Restaurant", null)
                        .WithMany("Images")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Menu", b =>
                {
                    b.HasOne("WebApplication1.Models.Restaurant", null)
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.MenuItem", b =>
                {
                    b.HasOne("WebApplication1.Models.Menu", null)
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.RestaurantBadge", b =>
                {
                    b.HasOne("WebApplication1.Models.Badge", "Badge")
                        .WithMany("RestaurantBadges")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantBadges")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.RestaurantKitchenType", b =>
                {
                    b.HasOne("WebApplication1.Models.KitchenType", "KitchenType")
                        .WithMany("RestaurantKitchenTypes")
                        .HasForeignKey("KitchenTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantKitchenTypes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Setting", b =>
                {
                    b.HasOne("WebApplication1.Models.User", null)
                        .WithOne("Settings")
                        .HasForeignKey("WebApplication1.Models.Setting", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.SettingKitchenType", b =>
                {
                    b.HasOne("WebApplication1.Models.KitchenType", "KitchenType")
                        .WithMany("SettingKitchenTypes")
                        .HasForeignKey("KitchenTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Setting", "Setting")
                        .WithMany("SettingKitchenTypes")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.SettingPriceclass", b =>
                {
                    b.HasOne("WebApplication1.Models.Priceclass", "Priceclass")
                        .WithMany("SettingPriceclasses")
                        .HasForeignKey("PriceclassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Setting", "Setting")
                        .WithMany("SettingPriceclasses")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.UserRestaurant", b =>
                {
                    b.HasOne("WebApplication1.Models.Restaurant", "Restaurant")
                        .WithMany("UserRestaurants")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.User", "User")
                        .WithMany("UserRestaurants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}