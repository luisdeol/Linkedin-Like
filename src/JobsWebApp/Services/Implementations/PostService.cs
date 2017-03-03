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

        public void DeletePost(Post post)
        {
            _unitOfWork.PostRepository.Delete(post);
            _unitOfWork.Save();
        }

        public Post FindPost(int id)
        {
            return _unitOfWork.PostRepository.FindById(id);
        }

        public void EditPost(Post post)
        {
            _unitOfWork.PostRepository.Edit(post);
            _unitOfWork.Save();
        }
    }

}
