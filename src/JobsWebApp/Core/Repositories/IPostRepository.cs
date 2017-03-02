using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll();
        void Add(Post post);
        void Delete(int id);
        void Edit(Post post);
        Post FindById(int id);
    }
}
