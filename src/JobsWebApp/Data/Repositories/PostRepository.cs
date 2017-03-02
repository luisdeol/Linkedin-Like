using System;
using System.Collections.Generic;
using System.Linq;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public void Add(Post post)
        {
            _context.Posts.Add(post);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Post post)
        {
            throw new NotImplementedException();
        }

        public Post FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}