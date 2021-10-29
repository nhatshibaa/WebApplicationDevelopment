using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFood.Data;

namespace MvcFood.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFoodContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFoodContext>>()))
            {
                // Look for any movies.
                if (context.Food.Any())
                {
                    return;   // DB has been seeded
                }

                context.Food.AddRange(
                    new Food
                    {
                        Name = "Kem chocolate",
                        ManufacturingDate = DateTime.Parse("2021-10-29"),
                        Category = "Kem",
                        Price = 1.99M,
                        Rating = "7"
                    },

                    new Food
                    {
                        Name = "Mỳ tôm Hảo Hảo",
                        ManufacturingDate = DateTime.Parse("2021-10-29"),
                        Category = "Mỳ gói",
                        Price = 3.39M,
                        Rating = "10"
                    },

                    new Food
                    {
                        Name = "Bim bim",
                        ManufacturingDate = DateTime.Parse("2021-10-29"),
                        Category = "Đồ ăn vặt",
                        Price = 1.59M,
                        Rating = "7"
                    },

                    new Food
                    {
                        Name = "Gà rán KFC",
                        ManufacturingDate = DateTime.Parse("2021-10-29"),
                        Category = "Đồ ăn nhanh",
                        Price = 9.99M,
                        Rating = "8"
                    },

                    new Food
                    {
                        Name = "Gà rán KFC",
                        ManufacturingDate = DateTime.Parse("2021-10-29"),
                        Category = "Đồ ăn nhanh",
                        Price = 9.99M,
                        Rating = "9"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
