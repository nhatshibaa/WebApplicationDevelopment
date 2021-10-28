using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcFood.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
