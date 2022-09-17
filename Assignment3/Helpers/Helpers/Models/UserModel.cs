using System.ComponentModel.DataAnnotations;

namespace Helpers.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter name")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter UserName")]
        [MinLength(3, ErrorMessage = "Name must be of minimum three characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter correct Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
                    ErrorMessage = "Required with (1 Uppercase, 1 Number, 1 Special Char and 1 Lowercase Char) and Min Length :8 Chars")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm Password Does not Match")]
        public string ConfirmPassword { get; set; }
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please enter correct mobile")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter Gender Information")]
        public string Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [Attributes.ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool IsTerms { get; set; }

    }
}
