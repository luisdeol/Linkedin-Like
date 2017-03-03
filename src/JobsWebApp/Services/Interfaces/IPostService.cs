using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IPostService
    {
        void AddPost(Post post);
        Post GetPost(int id);
        IEnumerable<Post> GetAllPosts();
        void DeletePost(Post post);
        void EditPost(Post post);
    }
}