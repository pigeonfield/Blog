using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescr { get; set; }
        public List<Post> Posts { get; set; }

        internal object Where(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
