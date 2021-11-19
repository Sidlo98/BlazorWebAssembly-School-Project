using WebShop.Models;

namespace WebShop.Services
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Product product);

        Task RemoveFromCart(Product product);
    }
}
