using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using System.IO.Pipelines;

namespace NZPureJadeShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IJadeRepository _jadeRepository;

        public SearchController(IJadeRepository jadeRepository)
        {
            _jadeRepository = jadeRepository;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allJades = _jadeRepository.AllJades;
            return Ok(_jadeRepository.AllJades);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_jadeRepository.AllJades.Any(j => j.JadeId == id))
                return NotFound();

            return Ok(_jadeRepository.AllJades.Where(j => j.JadeId == id));
        }
        [HttpPost]
        public IActionResult searchJades([FromBody] string searchQuery)
        {
            IEnumerable<Jade> jades = new List<Jade>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                jades = _jadeRepository.SearchJades(searchQuery);
            }

            return new JsonResult(jades);

        }
    }
}
