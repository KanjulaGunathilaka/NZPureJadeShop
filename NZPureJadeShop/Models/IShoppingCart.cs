using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Jade jade);
        int RemoveFromCart(Jade jade);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();

        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
