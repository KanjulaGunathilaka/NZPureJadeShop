using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;

namespace NZPureJadeShop.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IShoppingCart _ShoppingCart;

        public OrderController(IOrderRepository orderRepository, IShoppingCart shoppingCart)
        {
            _OrderRepository = orderRepository;
            _ShoppingCart = shoppingCart;

        }

        public IActionResult Checkout() { return View(); }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _ShoppingCart.GetShoppingCartItems();
            _ShoppingCart.ShoppingCartItems = items;


            if (_ShoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                _OrderRepository.CreateOrder(order);
                _ShoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "We appreciate your choice and are delighted to have you as a customer. Your exquisite jade piece will be prepared with the utmost care and attention.";
            return View();
        }
    }
}
