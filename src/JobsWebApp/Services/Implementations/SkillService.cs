using System;
using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddSkill(Skill skill)
        {
            _unitOfWork.SkillRepository.Add(skill);
            _unitOfWork.Save();
        }

        public Skill GetSkill(int id)
        {
            return _unitOfWork.SkillRepository.FindById(id);
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return _unitOfWork.SkillRepository.GetAll();
        }

        public void DeleteSkill(Skill skill)
        {
            _unitOfWork.SkillRepository.Delete(skill);
            _unitOfWork.Save();
        }

        public void EditSkill(Skill skill)
        {
            _unitOfWork.SkillRepository.Edit(skill);
            _unitOfWork.Save();
        }
    }
}