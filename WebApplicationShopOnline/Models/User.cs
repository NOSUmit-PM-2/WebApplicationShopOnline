using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        private int TempId = 0; 
        public int IdUser { get; } 
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public string Telephone { get; }
        public string Email { get; }

        public User(string name, string login, string password, string telephone, string email)
        {
            IdUser = TempId++; 
            Name = name;
            Login = login;
            Password = password;
            Telephone = telephone;
            Email = email;
        }
    }
}
