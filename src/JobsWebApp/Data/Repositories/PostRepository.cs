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
            return _context.Posts.OrderByDescending(p=> p.CreatedAt);
        }

        public void Add(Post post)
        {
            _context.Posts.Add(post);
        }

        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
        }

        public void Edit(Post post)
        {
            _context.Posts.Update(post);
        }

        public Post FindById(int id)
        {
            return _context.Posts.SingleOrDefault(p=> p.Id == id);
        }
    }
}