using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface IUserProfileRepository
    {
        IEnumerable<UserProfile> GetAll();
        void Add(UserProfile userProfile);
        void Delete(int id);
        void Edit(UserProfile userProfile);
        UserProfile FindById(int id);
    }
}
