using System;
using System.Collections.Generic;
using System.Linq;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Data.Repositories
{
    class JobOfferRepository : IJobOfferRepository
    {
        private readonly ApplicationDbContext _context;

        public JobOfferRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<JobOffer> GetAll()
        {
            return _context.JobOffers.ToList();
        }

        public void Add(JobOffer jobOffer)
        {
            _context.JobOffers.Add(jobOffer);
        }

        public void Delete(JobOffer jobOffer)
        {
            _context.JobOffers.Remove(jobOffer);
        }

        public void Edit(JobOffer jobOffer)
        {
            _context.JobOffers.Update(jobOffer);
        }

        public JobOffer FindById(int id)
        {
            return _context.JobOffers.SingleOrDefault(jb => jb.Id == id);
        }
    }
}