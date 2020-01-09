using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PartyInvites.Models
{
    public class GuestResponse 
    {
        [Required(ErrorMessage = "Please input your first and last name")]
        public string Name  { get; set; }

        [Required(ErrorMessage = "Please insert e-mail address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please insert a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please insert phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Do you come to a party?. Please select the answer")]
        public bool? WillAttend { get; set; }
    }
}
