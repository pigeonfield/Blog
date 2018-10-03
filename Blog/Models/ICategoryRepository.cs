using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
