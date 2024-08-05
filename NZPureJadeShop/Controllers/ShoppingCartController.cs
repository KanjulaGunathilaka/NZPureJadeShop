using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using NZPureJadeShop.Models.Repository;
using NZPureJadeShop.ViewModels;

namespace NZPureJadeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IJadeRepository _jadeRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IJadeRepository jadeRepository, IShoppingCart shoppingCart)
        {
            _jadeRepository = jadeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingcCartVeiwModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingcCartVeiwModel);
        }
        public RedirectToActionResult AddToShoppingCart(int jadeId)
        {
            var selectedJade = _jadeRepository.AllJades.FirstOrDefault(j => j.JadeId == jadeId);
            if (selectedJade != null)
            {
                _shoppingCart.AddToCart(selectedJade);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int jadeId)
        {
            var selectedJade = _jadeRepository.AllJades.FirstOrDefault(p => p.JadeId == jadeId);
            if (selectedJade != null)
            {
                _shoppingCart.RemoveFromCart(selectedJade);
            }
            return RedirectToAction("Index");
        }
    }
}
