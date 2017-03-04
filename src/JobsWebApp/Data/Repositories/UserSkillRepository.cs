using System;
using System.Collections.Generic;
using System.Linq;
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
            return _context.UserSkills.ToList();
        }

        public void Add(UserSkill userSkill)
        {
            _context.UserSkills.Add(userSkill);
        }

        public void Delete(UserSkill userSkill)
        {
            _context.UserSkills.Remove(userSkill);
        }

        public void Edit(UserSkill userSkill)
        {
            _context.UserSkills.Update(userSkill);
        }

        public UserSkill FindById(int id)
        {
            return _context.UserSkills.SingleOrDefault(us=> us.Id == id);
        }
    }
}