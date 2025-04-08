using WebApplicationShopOnline.Models;

public interface IUserRepository
{
    List<User> GetAll();
    void Add(User user);
    User? GetByName(string name);
    User? GetById(Guid id);
}
