﻿using SebastianMortaLab6Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.ViewModel
{
    public class FoodListViewModel
    {
        public IEnumerable<Food> Foods { get; set; }
        public string CurrentCategory { get; set; }
    }
}
