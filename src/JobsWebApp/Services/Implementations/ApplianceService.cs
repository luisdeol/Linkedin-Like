﻿using System;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Appliance> GetAllAppliances()
        {
            throw new NotImplementedException();
        }

        public void DeleteAppliance(Appliance appliance)
        {
            throw new NotImplementedException();
        }

        public void EditAppliance(Appliance appliance)
        {
            throw new NotImplementedException();
        }

        public void AddAppliance(Appliance appliance)
        {
            throw new NotImplementedException();
        }
    }
}
