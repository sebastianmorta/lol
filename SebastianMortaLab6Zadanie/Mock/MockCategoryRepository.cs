using SebastianMortaLab6Zadanie.Interfaces;
using SebastianMortaLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Mock
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Vegan", Description = "All Vegan dish"},
                    new Category { CategoryName = "non-Vegan", Description = "All non-Vegan dish"}
                };
            }

            
        }
    }
}
