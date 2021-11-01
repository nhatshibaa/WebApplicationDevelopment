using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFood.Models
{
    public class Food
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Tên đồ ăn")]
        public string Name { get; set; }

        [Display(Name = "Ngày sản xuất")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        //[StringLength(30)]
        [Display(Name = "Danh mục")]
        public string Category { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Giá")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(1, 10)]
        [StringLength(5)]
        [Required]
        [Display(Name = "Đánh giá")]
        public string Rating { get; set; }

    }
}
