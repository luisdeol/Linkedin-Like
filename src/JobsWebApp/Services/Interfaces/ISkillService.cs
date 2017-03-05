using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface ISkillService
    {
        void AddSkill(Skill skill);
        Skill GetSkill(int id);
        IEnumerable<Skill> GetAllSkills();
        void DeleteSkill(Skill skill);
        void EditSkill(Skill skill);
    }
}
