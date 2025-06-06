namespace WebApplicationShopOnline.Models
{
    public class UserViewModel
    {
        public UserViewModel(string name, string login, string password, string phone)
        {
            Id = Guid.NewGuid();
            Name = name;
            Login = login;
            Password = password;
            Phone = phone;
        }

        public Guid Id { get; set; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
        public string Phone { get; }
    }
}