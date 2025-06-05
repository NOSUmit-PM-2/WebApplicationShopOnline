namespace WebApplicationShopOnline.Models
{
    public class User
    {
        public User(string name, string login, string password, string email,string phone)
        {
            Name = name;
            Login = login;
            Password = password;
            Phone = phone;
            IdUser = Guid.NewGuid();
            Email = email;
        }

        public Guid IdUser { get; set; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public string Phone { get; }
        public string Email { get; set; }
    }
}
