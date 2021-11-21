using Blazored.LocalStorage;
using WebShop.Models;

namespace WebShop.Services
{
    public class UserService : IUserService
    {
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;

        public UserService(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
        }

        public async Task SetUser(User user)
        {
            await localStorage.SetItemAsync("user", user);
            OnChange.Invoke();
        }

        public async Task Logout()
        {
            await localStorage.RemoveItemAsync("user");
            OnChange.Invoke();
        }
    }
}
