using System;
using System.Collections.Generic;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class JobOfferRepository : IJobOfferRepository
    {
        private ApplicationDbContext _context;

        public JobOfferRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<JobOffer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(JobOffer jobOffer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(JobOffer jobOffer)
        {
            throw new NotImplementedException();
        }

        public JobOffer FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}