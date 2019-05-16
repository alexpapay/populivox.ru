using System.ComponentModel.DataAnnotations;

namespace PopuliVoxRu.View.Data.ViewModels.Identity
{
    public class UserLoginViewModel
    {
        [Required]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
