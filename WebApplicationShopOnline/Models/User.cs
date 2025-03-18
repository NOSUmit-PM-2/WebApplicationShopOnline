using System.Security.Cryptography.X509Certificates;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        public Guid IdUser { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public User(string name,string email,string password,string telephone)
        {
            IdUser = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            Telephone = telephone;
        }
    }
}
