using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SebastianMortaLab6Zadanie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Foods.Any())
            {
                context.AddRange
                (
                    new Food
                    {
                        Name = "pizza1",
                        Price = 7.95M,
                        ShortDescription = "dobra pizza",
                        LongDescription = "",
                        Category = Categories["vegan"],
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    }, 
                    new Food
                    {
                        Name = "pizza1",
                        Price = 7.95M,
                        ShortDescription = "dobra pizza",
                        LongDescription = "",
                        Category = Categories["vegan"],
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Food
                    {
                        Name = "pizza1",
                        Price = 7.95M,
                        ShortDescription = "dobra pizza",
                        LongDescription = "",
                        Category = Categories["vegan"],
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Food
                    {
                        Name = "pizza1",
                        Price = 7.95M,
                        ShortDescription = "dobra pizza",
                        LongDescription = "",
                        Category = Categories["vegan"],
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    }
                  
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic Foods" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic Foods" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
