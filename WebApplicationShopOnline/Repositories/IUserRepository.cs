using System.Collections.Generic;

namespace WebApplicationShopOnline.Models.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByName(string name);
    }
}

