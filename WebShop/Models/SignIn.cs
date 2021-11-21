using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class SignIn
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} must be provided")]
        public string UserHash { get; set; }
    }
}
