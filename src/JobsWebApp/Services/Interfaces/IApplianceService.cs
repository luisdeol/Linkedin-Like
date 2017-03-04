using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IApplianceService
    {
        void AddAppliance(Appliance appliance);
        Appliance GetAppliance(int id);
        IEnumerable<Appliance> GetAllAppliances();
        void DeleteAppliance(Appliance appliance);
        void EditAppliance(Appliance appliance);
    }
}
