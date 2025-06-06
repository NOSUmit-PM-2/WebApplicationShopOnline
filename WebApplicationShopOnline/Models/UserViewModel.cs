namespace WebApplicationShopOnline.Models
{
    public class UserViewModel
    {
        static int counter = 0;
        public int IdUser { get; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public UserViewModel(string name, string login, string password, string telephone, string email)
        {
            IdUser = counter;
            Name = name;
            Login = login;
            Password = password;
            Telephone = telephone;
            Email = email;
            counter++;
        }
    }
}
