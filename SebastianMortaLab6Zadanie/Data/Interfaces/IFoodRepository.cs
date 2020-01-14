using SebastianMortaLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Interfaces
{
    public interface IFoodRepository
    {
        IEnumerable<Food> Foods { get; }
        IEnumerable<Food> PreferredFoods { get; }
        Food GetFoodById(int FoodId);
    }
}
