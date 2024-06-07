using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using System.IO.Pipelines;

namespace NZPureJadeShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private readonly IJadeRepository _jadeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CrudController(IJadeRepository jadeRepository, ICategoryRepository categoryRepository)
        {
            _jadeRepository = jadeRepository;
            _categoryRepository = categoryRepository;

        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var allCategories = _categoryRepository.AllCategories;
            return Ok(allCategories);
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var allJades = _jadeRepository.AllJades;
        //    return Ok(_jadeRepository.AllJades);
        //}

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_jadeRepository.AllJades.Any(j => j.JadeId == id))
                return NotFound();

            return Ok(_jadeRepository.AllJades.Where(j => j.JadeId == id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateJade([FromBody] Jade jade)
        {
            if(jade == null) { return BadRequest(); };

            await _jadeRepository.SaveJade(jade);

            // IEnumerable<Jade> jades = new List<Jade>();

            //if (!string.IsNullOrEmpty(searchQuery))
            //{

            //    jades = _jadeRepository.SearchJades(searchQuery);
            //}

            return Ok(jade);

        }
    }
}
