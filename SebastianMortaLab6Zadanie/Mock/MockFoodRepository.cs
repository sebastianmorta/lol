using SebastianMortaLab6Zadanie.Interfaces;
using SebastianMortaLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Mock
{
    public class MockFoodRepository:IFoodRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Food> Foods
        {
            get
            {
                return new List<Food>
                {
                    new Food
                    {
                        Name = "Pizza Margarita",
                        Price = 10M,
                        ShortDescription = "ser, sos, ciasto",
                        LongDescription = "Powszechne przekonanie mówi, że w czerwcu 1889 r. Pizzaiolo Raffaele Esposito , szef kuchni pizzerii Brandi, wynalazł danie o nazwie „ Pizza Margherita ” na cześć królowej Włoch, Margherity Sabaudzkiej i włoskiego zjednoczenia , ponieważ polewy są pomidorowe (czerwone), mozzarella (biała) i bazylia (zielona), reprezentujące te same kolory flagi narodowej Włoch . ",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "/Images/pizzamargheritatop.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "/Images/pizzamargheritatop.jpg"

                    },
                    new Food
                    {
                        Name = "capriciosa",
                        Price = 10M,
                        ShortDescription = "sos, ser, ciasto, szynka, pieczarki",
                        LongDescription = "Pizza capricciosa – rodzaj pizzy w kuchni włoskiej, ze składnikami: ser mozzarella, pieczona szynka, grzyby (m.in. pieczarki), karczochy i pomidory.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "/Images/capriciosa.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "/Images/capriciosa.jpg"

                    },
                    new Food
                    {
                        Name = "Hawajska",
                        Price = 10M,
                        ShortDescription = "sos, ser, ciasto, szynka, ananas",
                        LongDescription = "",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "/Images/hawajska.jpg",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = "/Images/hawajska.jpg"

                    },
                    new Food
                    {
                        Name = "Farmerska",
                        Price = 10M,
                        ShortDescription = "sos, ser, ciasto, mięso, warzywa",
                        LongDescription = "",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        InStock = true,
                        IsPreferredFood = true,
                        ImageThumbnailUrl = ""

                    }

                };
            }
        }
        public IEnumerable<Food> PreferredFoods { get; }
        public Food GetFoodById(int FoodId)
        {
            throw new NotImplementedException();
        }
    }
}
