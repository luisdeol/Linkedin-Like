using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IUserSkillService
    {
        void AddUserSkill(UserSkill userSkill);
        UserSkill GetUserSkill(int id);
        IEnumerable<UserSkill> GetAllUserSkills();
        void DeleteUserSkill(UserSkill userSkill);
        void EditUserSkill(UserSkill userSkill);
    }
}
