using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetAll();
        void Add(Skill skill);
        void Delete(Skill skill);
        void Edit(Skill skill);
        Skill FindById(int id);
    }
}