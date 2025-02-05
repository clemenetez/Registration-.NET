using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Ім'я користувача")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }

}
