using System;
using System.Collections.Generic;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class UserSkillRepository : IUserSkillRepository
    {
        private ApplicationDbContext _context;

        public UserSkillRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserSkill> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(UserSkill userSkill)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserSkill userSkill)
        {
            throw new NotImplementedException();
        }

        public UserSkill FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}