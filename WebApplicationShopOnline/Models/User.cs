using Microsoft.Extensions.Hosting;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid ID { get; }

        public User(string name, int age, string email, string password) 
        { 
            Name = name;
            Age = age;
            Email = email;
            Password = password;
            ID = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Email}, {Password}";
        }

    }
}
