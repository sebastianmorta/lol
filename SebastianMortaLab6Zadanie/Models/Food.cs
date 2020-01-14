﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianMortaLab6Zadanie.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string ShortDescription{ get; set; }
        public string LongDescription{ get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredFood { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
