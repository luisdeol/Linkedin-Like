using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly ApplicationDbContext _context;

        public SkillRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Skill> GetAll()
        {
            return _context.Skills.ToList();
        }

        public void Add(Skill skill)
        {
            _context.Skills.Add(skill);
        }

        public void Delete(Skill skill)
        {
            _context.Skills.Remove(skill);
        }

        public void Edit(Skill skill)
        {
            _context.Skills.Update(skill);
        }

        public Skill FindById(int id)
        {
            return _context.Skills.SingleOrDefault(a => a.Id == id);
        }
    }
}
