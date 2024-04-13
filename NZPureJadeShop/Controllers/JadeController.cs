using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models.IRepository;
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

            JadeListViewModel jadeListViewModel = new JadeListViewModel(_jadeRepository.AllJades, "All Jades");
            return View(jadeListViewModel);

        }
        public IActionResult Details(int id)
        {
            var jade = _jadeRepository.GetJadeById(id);

            if (jade == null)
            {
                return NotFound();
            }

            return View(jade);
        }
    }
}
