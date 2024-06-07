using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models.IRepository;
using NZPureJadeShop.ViewModels;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IJadeRepository _jadeRepository;

        public AdminController(ICategoryRepository categoryRepository, IJadeRepository jadeRepository)
        {
            _categoryRepository = categoryRepository;
            _jadeRepository = jadeRepository;
        }
        public IActionResult ManageJades()
        {
            var categories = _categoryRepository.AllCategories;
            var jades = _jadeRepository.AllJades;
            var adminViewModel = new AdminViewModel(categories, jades);
            return View(adminViewModel);
        }
    }
}