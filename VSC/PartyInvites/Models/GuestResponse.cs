using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models{

    public class GuestResponse{
        public int id {get; set;}
        [Required(ErrorMessage = "First name and last name")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Valid email")]
        public string Email {get; set;}

        [Required(ErrorMessage = "Phone number")]
        public string Phone {get; set;} 

        [Required(ErrorMessage = "Will you attend?")]
        public bool? WillAttend {get; set;}
    }
}