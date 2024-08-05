using Microsoft.AspNetCore.Mvc;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;

namespace NZPureJadeShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class JadeController : ControllerBase
    {
        private readonly IJadeRepository _jadeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public JadeController(IJadeRepository jadeRepository, ICategoryRepository categoryRepository)
        {
            _jadeRepository = jadeRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAllJades()
        {
            var allJades = _jadeRepository.AllJades.ToList();
            return Ok(allJades);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var jade = _jadeRepository.AllJades.FirstOrDefault(j => j.JadeId == id);
            if (jade == null)
                return NotFound();

            return Ok(jade);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJade([FromBody] Jade jade)
        {
            if (jade == null)
                return BadRequest();

            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == jade.CategoryId);
            if (category == null)
                return BadRequest("Invalid category ID");

            await _jadeRepository.SaveJade(jade);
            return Ok(jade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJade(int id, [FromBody] Jade jade)
        {
            if (jade == null || id != jade.JadeId)
                return BadRequest();

            var existingJade = await _jadeRepository.GetJadeById(id);
            if (existingJade == null)
                return NotFound();

            var category = await _categoryRepository.FindCategoryById(jade.CategoryId);
            if (category == null)
                return BadRequest("Invalid category ID");

            // Update the existingJade entity with the new values
            existingJade.Name = jade.Name;
            existingJade.ShortDescription = jade.ShortDescription;
            existingJade.LongDescription = jade.LongDescription;
            existingJade.SpecialInformation = jade.SpecialInformation;
            existingJade.Price = jade.Price;
            existingJade.ImageUrl = jade.ImageUrl;
            existingJade.ImageThumbnailUrl = jade.ImageThumbnailUrl;
            existingJade.IsPopularJadeGifts = jade.IsPopularJadeGifts;
            existingJade.InStock = jade.InStock;
            existingJade.CategoryId = jade.CategoryId;
            existingJade.Category = category;

            await _jadeRepository.UpdateJade(existingJade);
            return Ok(existingJade);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJade(int id)
        {
            var jade = _jadeRepository.AllJades.FirstOrDefault(j => j.JadeId == id);
            if (jade == null)
                return NotFound();

            await _jadeRepository.DeleteJade(id);
            return Ok(jade);
        }
    }
}
