using System;
using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class UserSkillService : IUserSkillService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserSkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddUserSkill(UserSkill userSkill)
        {
            _unitOfWork.UserSkillRepository.Add(userSkill);
            _unitOfWork.Save();
        }

        public UserSkill GetUserSkill(int id)
        {
            return _unitOfWork.UserSkillRepository.FindById(id);
        }

        public IEnumerable<UserSkill> GetAllUserSkills()
        {
            return _unitOfWork.UserSkillRepository.GetAll();
        }

        public void DeleteUserSkill(UserSkill userSkill)
        {
            _unitOfWork.UserSkillRepository.Delete(userSkill);
            _unitOfWork.Save();
        }

        public void EditUserSkill(UserSkill userSkill)
        {
            _unitOfWork.UserSkillRepository.Edit(userSkill);
            _unitOfWork.Save();
        }
    }
}