using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description od a product")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Please specify a valid price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Specify a category")]
        [Display(Name = "Catgories")]
        public string Category { get; set; }
    }
}
