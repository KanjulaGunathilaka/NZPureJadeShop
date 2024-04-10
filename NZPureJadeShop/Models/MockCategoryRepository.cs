namespace NZPureJadeShop.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Corded Necklaces",Description = "Corded Necklaces"},
                new Category {CategoryId = 2,CategoryName = "Pounamu Earrings", Description = "Pounamu Earrings"},
                new Category {CategoryId = 3,CategoryName = "Bangles & Bracelets", Description = "Bangles & Bracelets"},
                new Category {CategoryId = 4,CategoryName = "Sculptures", Description = "Sculptures"}

            };
    }
}
