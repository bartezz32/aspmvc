using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product()
                    {
                        Name = "Kyak",
                        Description = "Boat for 1 person",
                        Category = "Water Sports",
                        Price = 275
                    },
                    new Product()    
                    {
                        Name = "Life jacket",
                        Description = "Secure",
                        Category = "Water Sports",
                        Price = 48.95m
                    },
                    new Product()
                    {
                        Name = "Ball",
                        Description = "Accepted by FIFA",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product()
                    {
                        Name = "Corner Flag",
                        Description = "Very good looking at soccer arena",
                        Category = "Soccer",
                        Price = 34.9m
                    },
                    new Product()
                    {
                        Name = "Stadion",
                        Description = "Folding arena for 35000 people",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product()
                    {
                        Name = "Cap",
                        Description = "Increase brain accuracy over 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product()
                    {
                        Name = "Unstable chair",
                        Description = "Decrease enemy chance for win",
                        Category = "Chess",
                        Price = 75,
                    },
                    new Product()
                    {
                        Name = "Human chess-board",
                        Description = "Family game",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product()
                    {
                        Name = "Shakes king",
                        Description = "Figure made of gold and diamonds",
                        Category = "Chess",
                        Price = 1200
                    });
                context.SaveChanges();
            }
        }
    }

}