using System;
using System.Collections.Generic;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class UserProfileRepository : IUserProfileRepository
    {
        private ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }

        public UserProfile FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}