using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFood.Models
{
    public class FoodCateViewModel
    {
        public List<Food> Foods { get; set; }
        public SelectList Category { get; set; }
        public string FoodCategory { get; set; }
        public string SearchString { get; set; }
    }
}
