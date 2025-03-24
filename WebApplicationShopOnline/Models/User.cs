using Microsoft.Extensions.Hosting;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        static int instanceCounter = 0;
        public int IdUser { get; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public User(string name, string login, string password, string telephone, string email)
        {
            IdUser = instanceCounter;
            Name = name;
            Login = login;
            Password = password;
            Telephone = telephone;
            Email = email;
            instanceCounter++;
        }
        public override string ToString()
        {
            return String.Join("\n", new String[] { IdUser.ToString(), Name, Login, Password, Telephone, Email });
        }
    }
}