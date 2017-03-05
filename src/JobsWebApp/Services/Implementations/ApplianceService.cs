using System;
using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class ApplianceService:IApplianceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplianceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Appliance GetAppliance(int id)
        {
            return _unitOfWork.ApplianceRepository.FindById(id);
        }

        public IEnumerable<Appliance> GetAllAppliances()
        {
            return _unitOfWork.ApplianceRepository.GetAll();
        }

        public void DeleteAppliance(Appliance appliance)
        {
            _unitOfWork.ApplianceRepository.Delete(appliance);
            _unitOfWork.Save();
        }

        public void EditAppliance(Appliance appliance)
        {
            _unitOfWork.ApplianceRepository.Edit(appliance);
            _unitOfWork.Save();
        }

        public void AddAppliance(Appliance appliance)
        {
            _unitOfWork.ApplianceRepository.Add(appliance);
            _unitOfWork.Save();
        }
    }
}
