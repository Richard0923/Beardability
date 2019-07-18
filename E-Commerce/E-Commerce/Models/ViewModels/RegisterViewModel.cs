using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
