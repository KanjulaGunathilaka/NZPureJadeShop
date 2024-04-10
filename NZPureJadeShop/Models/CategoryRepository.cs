// CategoryRepository.cs
using System;
using System.Collections.Generic;

namespace NZPureJadeShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        // Implement methods or properties defined in ICategoryRepository
        public IEnumerable<Category> AllCategories
        {
            get
            {
                // Here you would typically fetch categories from a database
                // For now, let's return some dummy data
                return new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName = "Category 1" },
                    new Category { CategoryId = 2, CategoryName = "Category 2" },
                    // Add more categories as needed
                };
            }
        }
    }
}
