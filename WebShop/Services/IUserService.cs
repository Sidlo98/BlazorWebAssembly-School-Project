using WebShop.Models;

namespace WebShop.Services
{
    public interface IUserService
    {
        event Action OnChange;
        Task SetUser(User user);
        Task Logout();
    }
}
