using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public User(string name, string email, string password, string telephone)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            Phone = telephone;
            Login = email; 
        }

        public User()
        {
        }
    }
}
