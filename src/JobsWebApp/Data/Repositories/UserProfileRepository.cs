using System;
using System.Collections.Generic;
using System.Linq;
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
            return _context.UserProfiles.ToList();
        }

        public void Add(UserProfile userProfile)
        {
            _context.UserProfiles.Add(userProfile);
        }

        public void Delete(UserProfile userProfile)
        {
            _context.UserProfiles.Remove(userProfile);
        }

        public void Edit(UserProfile userProfile)
        {
            _context.UserProfiles.Update(userProfile);
        }

        public UserProfile FindById(int id)
        {
            return _context.UserProfiles.SingleOrDefault(up=> up.Id == id);
        }
    }
}