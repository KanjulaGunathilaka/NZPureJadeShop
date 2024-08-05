using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using System.Linq;
using System.Threading.Tasks;

namespace NZPureJadeShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var allCategories = _categoryRepository.AllCategories.ToList();
            return Ok(allCategories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            await _categoryRepository.SaveCategory(category);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] Category category)
        {
            if (category == null || id != category.CategoryId)
                return BadRequest();

            var existingCategory = await _categoryRepository.FindCategoryById(id);

            if (existingCategory == null)
                return NotFound();

            existingCategory.CategoryName = category.CategoryName;
            existingCategory.Description = category.Description;

            try
            {
                await _categoryRepository.UpdateCategory(existingCategory);
                return Ok(existingCategory);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Conflict();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
                return NotFound();

            await _categoryRepository.DeleteCategory(id);
            return Ok(category);
        }
    }
}
