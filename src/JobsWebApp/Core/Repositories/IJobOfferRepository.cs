﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Core.Repositories
{
    public interface IJobOfferRepository
    {
        IEnumerable<JobOffer> GetAll();
        void Add(JobOffer jobOffer);
        void Delete(JobOffer jobOffer);
        void Edit(JobOffer jobOffer);
        JobOffer FindById(int id);
    }
}
