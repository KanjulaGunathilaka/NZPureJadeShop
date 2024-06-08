using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models.IRepository;

namespace NZPureJadeShop.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NZPureJadeShopDbContext _nzPureJadeShopDbContext;

        public CategoryRepository(NZPureJadeShopDbContext nzPureJadeShopDbContext)
        {
            _nzPureJadeShopDbContext = nzPureJadeShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _nzPureJadeShopDbContext.Categories.OrderBy(p => p.CategoryName);

        public async Task<Category> SaveCategory(Category category)
        {
            _nzPureJadeShopDbContext.Categories.Add(category);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            _nzPureJadeShopDbContext.Categories.Update(category);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> DeleteCategory(int categoryId)
        {
            var category = await _nzPureJadeShopDbContext.Categories.FindAsync(categoryId);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {categoryId} not found.");
            }

            _nzPureJadeShopDbContext.Categories.Remove(category);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> FindCategoryById(int categoryId)
        {
            return await _nzPureJadeShopDbContext.Categories.FindAsync(categoryId);
        }
    }
}

