using System;
using System.Collections.Generic;
using System.Linq;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class ApplianceRepository : IApplianceRepository
    {
        private ApplicationDbContext _context;

        public ApplianceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Appliance> GetAll()
        {
            return _context.Appliances.ToList();
        }

        public void Add(Appliance appliance)
        {
            _context.Appliances.Add(appliance);
        }

        public void Delete(Appliance appliance)
        {
            _context.Appliances.Remove(appliance);
        }

        public void Edit(Appliance appliance)
        {
            _context.Appliances.Update(appliance);
        }

        public Appliance FindById(int id)
        {
            return _context.Appliances.SingleOrDefault(a=> a.Id == id);
        }
    }
}