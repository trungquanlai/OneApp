using OneApp.Enums;
using PosRest.Data;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(OneAppContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name = CategoryTypes.Appetisers, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.BanhMi, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Beef, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.BeefRiceNoodleSoup, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Beverages, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Chicken, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.ChowMeinChowFun, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Desserts, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.EggFooYong, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.FriedRice, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Pork, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.RiceNoodleEggNoodleSoup, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.SeaFood, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.SteamedRice, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.TofuAndVegetables, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.Vermicelli, TimeStamp = DateTime.Now },
                new Category { Name = CategoryTypes.VietnameseSalad, TimeStamp = DateTime.Now },
            };

            foreach (Category c in categories)
                context.Categories.Add(c);

            var tables = new Table[]
            {
                new Table { Name = "Table 1", TimeStamp = DateTime.Now },
                new Table { Name = "Table 2" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 3" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 4" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 5" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 6" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 7" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 8" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 9" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 10" , TimeStamp = DateTime.Now },
                new Table { Name = "Table 11" , TimeStamp = DateTime.Now },
            };

            foreach (Table t in tables)
                context.Tables.Add(t);

            var users = new User[]
            {
                new User { Name = "admin", UserName = "admin", Password = "admin", Roles = "admin", TimeStamp = DateTime.Now},
                new User { Name = "user", UserName = "user", Password = "user", Roles = "user", TimeStamp = DateTime.Now},
            };

            foreach (User u in users)
                context.Users.Add(u);

            var itemsAppetiser = new Item[]
            {
                new Item {NameEN = "Crispy Wontons (5pcs)", NameVN = "Wonton chien", Price = 7m, TimeStamp = DateTime.Now },
                new Item {NameEN = "Spring Rolls (2pcs)", NameVN = "Cha Gio", Price = 7m, TimeStamp = DateTime.Now },
                new Item {NameEN = "Grilled Pork Skewers", NameVN = "Nem Nuong", Price = 8m, TimeStamp = DateTime.Now },
                new Item {NameEN = "Vietnamese Savoury Pancake w Prawns & Pork", NameVN = "Banh Xeo", Price = 21m, Description = "Slowly Pan Fried for Maximun Crunch so a Little Patience is Required", TimeStamp = DateTime.Now },
                new Item {NameEN = "Fried Chicken Wings", NameVN = "Canh Ga Chien Gion", Price = 8.5m, TimeStamp = DateTime.Now },
                new Item {NameEN = "Summer Rolls (2pcs) Prawns & Pork", NameVN = "CanhGoi Cuon", Price = 7.5m, TimeStamp = DateTime.Now },
                new Item {NameEN = "BBQ Pork", NameVN = "Dia Xa Xiu", Price = 11.5m, TimeStamp = DateTime.Now },
                new Item {NameEN = "Battled Squid", NameVN = "Muc Chien Don", Price = 11.5m, TimeStamp = DateTime.Now },
            };

            foreach (Item i in itemsAppetiser)
                context.Items.Add(i);


            var menus = new Menu[]
            {
                new Menu { Category = categories.SingleOrDefault(c => c.Name == CategoryTypes.Appetisers), Items = itemsAppetiser, TimeStamp = DateTime.Now }
            };

            foreach (Menu m in menus)
                context.Menus.Add(m);

            context.SaveChanges();
        }
    }
}
