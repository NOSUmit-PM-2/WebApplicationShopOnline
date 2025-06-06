namespace WebApplicationShopOnline.Models
{
    public class UserView
    {
        public UserView(string name, string login, string password, string phone, string email)
        {
            Name = name;
            Login = login;
            IdUser = Guid.NewGuid();
            Password = password;
            Phone = phone;
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