using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.ViewModels;

namespace NZPureJadeShop.Controllers
{
    public class JadeController : Controller
    {
        private readonly IJadeRepository _jadeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public JadeController(IJadeRepository jadeRepository, ICategoryRepository categoryRepository)
        {
            _jadeRepository = jadeRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            //return View(_jadeRepository.AllJades);

            JadeListViewModel jadeListViewModel = new JadeListViewModel(_jadeRepository.AllJades, "Cheese cakes");
            return View(jadeListViewModel);
        }
    }
}
