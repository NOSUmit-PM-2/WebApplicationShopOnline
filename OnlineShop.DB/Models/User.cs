using Microsoft.AspNetCore.Identity;


namespace OnlineShop.DB.Models
{
    public class User : IdentityUser
    {
        private string login;
        private string password;
        private string phone;

        public User(string userName, string login, string password, string phone, string email) : base(userName)
        {
            this.login = login;
            this.password = password;
            this.phone = phone;
            Email = email;
        }
    }
}
