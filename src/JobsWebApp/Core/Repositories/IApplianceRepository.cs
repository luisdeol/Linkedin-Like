using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface IApplianceRepository
    {
        IEnumerable<Appliance> GetAll();
        void Add(Appliance appliance);
        void Delete(Appliance appliance);
        void Edit(Appliance appliance);
        Appliance FindById(int id);
    }
}
