namespace WebApplicationShopOnline.Models
{
    public class UserViewModel
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public Guid Id { get; set; }
            public string Name { get; }
            public string Login { get; }
            public string Password { get; }
            public string Phone { get; }
            public string Email { get; set; }
        public UserViewModel(string name, string login, string password, string phone, string email)
        {
            Id = Guid.NewGuid();
                Name = name;
                Login = login;
                Password = password;
                Phone = phone;
                Email = email;
            
        }

        public UserViewModel(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}