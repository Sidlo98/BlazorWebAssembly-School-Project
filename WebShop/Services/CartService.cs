using Blazored.LocalStorage;
using WebShop.Models;

namespace WebShop.Services
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
        }

        public async Task AddToCart(Product product)
        {
            var cart = await localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var AlreadyExists = cart.Exists(x => x.product.Id == product.Id);

            if (AlreadyExists)
            {
                foreach (var item in cart.Where(x => x.product.Id == product.Id))
                {
                    item.quantity = item.quantity + 1;
                };
            }
            else
            {
                cart.Add(new CartItem() { product = product, quantity = 1 });
            }

            await localStorage.SetItemAsync("cart", cart);

            OnChange.Invoke();
        }

    }
}
