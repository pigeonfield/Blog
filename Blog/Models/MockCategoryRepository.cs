using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class MockCategoryRepository :ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Europe"},
                    new Category{CategoryId=2, CategoryName="America"},
                    new Category{CategoryId=3, CategoryName="Asia"},
                    new Category{CategoryId=4, CategoryName="Africa"}
                };
            }
        }
    }
}
