namespace WebApplicationStart.Models
{
    public class User
    {
        public int IdUser;
        public string Name;
        public string Email;
        public string Password;
        public string Login;
        public string Telephone;

        public User(int idUser, string name, string email, string password, string login, string telephone)
        {
            IdUser = idUser;
            Name = name;
            Email = email;
            Password = password;
            Login = login;
            Telephone = telephone;
        }
    }
}
