using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class JobOfferService : IJobOfferService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobOfferService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddJobOffer(JobOffer jobOffer)
        {
            _unitOfWork.JobOfferRepository.Add(jobOffer);
            _unitOfWork.Save();
        }

        public JobOffer GetJobOffer(int id)
        {
            return _unitOfWork.JobOfferRepository.FindById(id);
        }

        public IEnumerable<JobOffer> GetAllJobOffers()
        {
            return _unitOfWork.JobOfferRepository.GetAll();
        }

        public void EditJobOffer(JobOffer jobOffer)
        {
            _unitOfWork.JobOfferRepository.Edit(jobOffer);
            _unitOfWork.Save();
        }

        public void DeleteJobOffer(JobOffer jobOffer)
        {
            _unitOfWork.JobOfferRepository.Delete(jobOffer);
            _unitOfWork.Save();
        }
    }
}
