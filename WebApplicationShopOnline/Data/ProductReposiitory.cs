using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class ProductRepository
    {
        static List<Product> products = new List<Product>
        {
            new Product("Чебурек", "с сыром", 120, "https://www.chefmarket.ru/blog/wp-content/uploads/2021/05/cheburek-1-2000x1200.jpg"),
            new Product("Шаурма", "с мясом", 120, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.obozrevatel.com%2Ffood%2Frecipemain%2F2018%2F12%2F5%2F4-domashnya.jpg%3Fsize%3D636x424&f=1&nofb=1&ipt=d244b476e8ad189dc1124fb3d548f58f205a00dd0069c5044afe21e3d0bfe725&ipo=images")
        };

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
