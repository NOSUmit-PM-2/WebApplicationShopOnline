namespace WebApplicationShopOnline.Models
{
    public class User
    {
        private static int _instanceCounter = 0;
        public int IdUser { get; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public User(string name, string login, string password, string phone, string email)
        {
            IdUser = _instanceCounter++;
            Name = name;
            Login = login;
            Password = password;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return string.Join("\n", IdUser, Name, Login, Password, Phone, Email);
        }
    }
}
