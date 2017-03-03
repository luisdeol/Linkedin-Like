using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IJobOfferService
    {
        void AddJobOffer(JobOffer jobOffer);
        JobOffer GetJobOffer(int id);
        IEnumerable<JobOffer> GetAllJobOffers();
        void DeleteJobOffer(JobOffer jobOffer);
        void EditJobOffer(JobOffer jobOffer);
    }
}