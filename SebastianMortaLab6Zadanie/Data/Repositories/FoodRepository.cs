using Microsoft.EntityFrameworkCore;
using SebastianMortaLab6Zadanie.Interfaces;
using SebastianMortaLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Data.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _appDbContext;
        public FoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Food> Foods => _appDbContext.Foods.Include(c => c.Category);

        public IEnumerable<Food> PreferredFoods => _appDbContext.Foods.Where(p => p.IsPreferredFood).Include(c => c.Category);

        public Food GetFoodById(int foodId) => _appDbContext.Foods.FirstOrDefault(p => p.FoodId == foodId);
    }
}
