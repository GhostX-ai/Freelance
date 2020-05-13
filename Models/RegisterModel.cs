using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace FreelanceV2.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан Логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не указан Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Не указано Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не указана Фамилия")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int RoleId { get; set; }
        public int GenderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}