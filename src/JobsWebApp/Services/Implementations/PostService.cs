using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class PostService:IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddPost(Post post)
        {
            _unitOfWork.PostRepository.Add(post);
            _unitOfWork.Save();
        }

        public IEnumerable<Post> ListAllPosts()
        {
            return _unitOfWork.PostRepository.GetAll();
        }
    }

}
