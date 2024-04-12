using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.ViewModels;

namespace NZPureJadeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJadeRepository _jadeRepository;

        public HomeController(IJadeRepository jadeRepository)
        {
            _jadeRepository = jadeRepository;
        }
        public IActionResult Index()
        {
            var popularJadeGifts = _jadeRepository.PopularJadeGifts;
            var homeViewModel = new HomeViewModel(popularJadeGifts);
            return View(homeViewModel);
        }
    }
}
