using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IPostService
    {
        void AddPost(Post post);
        IEnumerable<Post> ListAllPosts();
    }
}