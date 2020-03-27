using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Paintings", Description="All acrylic paintings"},
                new Category{CategoryId=2, CategoryName="Decoupage", Description="All items made with the Degoupage technique"},
                new Category{CategoryId=3, CategoryName="Cards", Description="All greeting cards"}

            };
    }
}
