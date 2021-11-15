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

            context.SaveChanges();
        }
    }
}
