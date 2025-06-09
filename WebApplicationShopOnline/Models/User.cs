using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        

        public Guid IdUser { get; set; }

        [Required(ErrorMessage = "Введите имя пользователя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите телефон пользователя")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Введите адрес электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }


        public User(string name, string telephone, string email, string login, string password)
        {
            IdUser = Guid.NewGuid();
            Name = name;
            Telephone = telephone;
            Email = email;
            Login = login;
            Password = password;
        }


    }
}
