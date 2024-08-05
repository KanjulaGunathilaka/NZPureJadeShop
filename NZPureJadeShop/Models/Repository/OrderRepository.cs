namespace NZPureJadeShop.Models.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly NZPureJadeShopDbContext _nzPureJadeShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(NZPureJadeShopDbContext nzPureJadeShopDbContext, IShoppingCart shoppingCart)
        {
            _nzPureJadeShopDbContext = nzPureJadeShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    JadeId = shoppingCartItem.Jade.JadeId,
                    Price = shoppingCartItem.Jade.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _nzPureJadeShopDbContext.Orders.Add(order);

            _nzPureJadeShopDbContext.SaveChanges();
        }
    }
}

