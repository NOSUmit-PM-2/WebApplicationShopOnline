namespace WebApplicationShopOnline.Models
{
    public class UserRepository
    {
        private List<User> users = new List<User>();

        public UserRepository()
        {
            users.Add(new User { IdUser = 1, Name = "Саша", Login = "Sasha", Password = "sasha_best", Telephone = "+7 928 988 25 45", Email = "Sasha@www.com" });
            users.Add(new User { IdUser = 2, Name = "Таня", Login = "Tanya", Password = "Tanya_best", Telephone = "+7 928 988 25 45", Email = "Tanya@www.com" });
            users.Add(new User { IdUser = 3, Name = "Виктор", Login = "Victor", Password = "sasha_best", Telephone = "+7 928 988 25 45", Email = "Victor@www.com" });
            users.Add(new User { IdUser = 4, Name = "Ваня", Login = "Vanya", Password = "sasha_best", Telephone = "+7 928 988 25 45", Email = "Vanya@www.com" });
            users.Add(new User { IdUser = 5, Name = "Моня", Login = "Monya", Password = "sasha_best", Telephone = "+7 928 988 25 45", Email = "Monya@www.com" });
            users.Add(new User { IdUser = 6, Name = "Карл", Login = "Carl", Password = "sasha_best", Telephone = "+7 928 988 25 45", Email = "Carl@www.com" });
            users.Add(new User { IdUser = 7, Name = "Саша", Login = "Sasha_Worst", Password = "sasha_bad", Telephone = "+7 928 988 25 45", Email = "Sasha_Worst@www.com" });

        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(x => x.IdUser == id);
        }

        public User FindUserByName(string name)
        {
            return users.FirstOrDefault(x => x.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
    