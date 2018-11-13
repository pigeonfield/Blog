using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.BL
{
    public interface IPostModel
    {
        PostViewModel GetPostById(int id);
    }
}
