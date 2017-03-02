using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IJobOfferService
    {
        void AddJobOffer(JobOffer jobOffer);
        IEnumerable<JobOffer> GetAllJobOffers();
        JobOffer GetJobOffer(int id);
    }
}