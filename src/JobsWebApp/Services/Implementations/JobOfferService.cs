using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Implementations
{
    public class JobOfferService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobOfferService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddJobOffer(JobOffer jobOffer)
        {
            _unitOfWork.JobRepository.Add(jobOffer);
            _unitOfWork.Save();
        }

        public JobOffer GetJobOffer(int id)
        {
            return _unitOfWork.JobRepository.FindById(id);
        }

        public IEnumerable<JobOffer> GetAllJobOffers()
        {
            return _unitOfWork.JobRepository.GetAll();
        }
    }
}
