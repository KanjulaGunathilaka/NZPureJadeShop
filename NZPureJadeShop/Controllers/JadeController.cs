using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using NZPureJadeShop.ViewModels;
using System.IO.Pipelines;

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
        //public IActionResult List()
        //{
        //    //return View(_jadeRepository.AllJades);

        //    JadeListViewModel jadeListViewModel = new JadeListViewModel(_jadeRepository.AllJades, "All Jades");
        //    return View(jadeListViewModel);

        //}

        public ViewResult List(string category)
        {
            IEnumerable<Jade> jades;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                jades = _jadeRepository.AllJades.OrderBy(j => j.JadeId);
                currentCategory = "All jades";
            }
            else
            {
                jades = _jadeRepository.AllJades.Where(p => p.Category.CategoryName == category).OrderBy(p => p.JadeId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new JadeListViewModel(jades, currentCategory));
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

        public IActionResult Search()
        {
            return View();
        }

    }
}
