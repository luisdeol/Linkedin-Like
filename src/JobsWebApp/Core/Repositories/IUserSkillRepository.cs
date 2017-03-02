using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    interface IUserSkillRepository
    {
        IEnumerable<UserSkill> GetAll();
        void Add(UserSkill userSkill);
        void Delete(int id);
        void Edit(UserSkill userSkill);
        UserSkill FindById(int id);
    }
}
