using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void Add(Appliance appliance)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Appliance appliance)
        {
            throw new NotImplementedException();
        }

        public Appliance FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}