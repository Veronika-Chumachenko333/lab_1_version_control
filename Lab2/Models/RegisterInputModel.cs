using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class RegisterInputModel
    {
        [Required(ErrorMessage = "ПІБ обов'язкове")]
        [Display(Name = "ПІБ")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Електронна пошта обов'язкова")]
        [EmailAddress(ErrorMessage = "Невірний формат пошти")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обов'язковий")]
        [StringLength(100, ErrorMessage = "Пароль має містити мінімум {2} символи", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}