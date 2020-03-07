﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Enter name and surname")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your data in line 1")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Specify city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter a state name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Enter a country name")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }

}