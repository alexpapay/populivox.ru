using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PopuliVoxRu.View.Data.ViewModels.Identity
{
    public class UserRegisterViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public int SexId{ get; set; }

        [Required]
        [Display(Name = "Пол")]
        public List<SelectListItem> SexList { get; set; }

        [Required]
        [Display(Name = "Уровень")]
        public int SkillLevelId { get; set; }

        [Required]
        [Display(Name = "Уровень")]
        public List<SelectListItem> SkillLevelList { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
