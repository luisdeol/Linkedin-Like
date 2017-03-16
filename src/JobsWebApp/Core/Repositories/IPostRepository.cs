using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll(int id);
        void Add(Post post);
        void Delete(Post post);
        void Edit(Post post);
        Post FindById(int id);
    }
}
