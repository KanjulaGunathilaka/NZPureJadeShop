using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly NZPureJadeShopDbContext _nzPureJadeShopDbContext;

        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(NZPureJadeShopDbContext nzPureJadeShopDbContext)
        {
            _nzPureJadeShopDbContext = nzPureJadeShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            NZPureJadeShopDbContext context = services.GetService<NZPureJadeShopDbContext>() ?? throw new Exception("Error Initailizing");
            String cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }
        public void AddToCart(Jade jade)
        {
            var ShoppingCartItem = _nzPureJadeShopDbContext.ShoppingCartItems.SingleOrDefault(s => s.Jade.JadeId == jade.JadeId && s.ShoppingCartId == ShoppingCartId);

            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Jade = jade,
                    Amount = 1
                };
                _nzPureJadeShopDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Amount++;

            }
            _nzPureJadeShopDbContext.SaveChanges();
        }
        public int RemoveFromCart(Jade jade)
        {
            var ShoppingCartItem = _nzPureJadeShopDbContext.ShoppingCartItems.SingleOrDefault(s => s.Jade.JadeId == jade.JadeId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;
            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    localAmount = ShoppingCartItem.Amount;
                }

                else
                {
                    _nzPureJadeShopDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }

            }
            _nzPureJadeShopDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _nzPureJadeShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Jade).ToList();
        }
        public void ClearCart()
        {
            var CartItems = _nzPureJadeShopDbContext.ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _nzPureJadeShopDbContext.ShoppingCartItems.RemoveRange(CartItems);
            _nzPureJadeShopDbContext.SaveChanges(true);
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _nzPureJadeShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Jade.Price * c.Amount).Sum();
            return total;
        }


    }
}
