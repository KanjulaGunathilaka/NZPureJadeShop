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
    }
}

