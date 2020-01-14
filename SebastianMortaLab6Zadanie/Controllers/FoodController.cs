using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SebastianMortaLab6Zadanie.Interfaces;
using SebastianMortaLab6Zadanie.ViewModel;

namespace SebastianMortaLab6Zadanie.Controllers
{
    public class FoodController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFoodRepository _foodRepository;

        public FoodController(ICategoryRepository categoryRepository, IFoodRepository foodRepository)
        {
            _categoryRepository = categoryRepository;
            _foodRepository = foodRepository;
        }

        public ViewResult List()
        {
            ViewBag.Name = "dotnet, how";
            var foods = _foodRepository.Foods;
            FoodListViewModel vm = new FoodListViewModel();
            vm.Foods = _foodRepository.Foods;
            vm.CurrentCategory = "FoodCategory";
            return View(vm);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}