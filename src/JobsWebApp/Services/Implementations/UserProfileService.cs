using System;
using System.Collections.Generic;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;

namespace JobsWebApp.Services.Implementations
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddUserProfile(UserProfile userProfile)
        {
            _unitOfWork.UserProfileRepository.Add(userProfile);
            _unitOfWork.Save();
        }

        public UserProfile GetUserProfile(int id)
        {
            return _unitOfWork.UserProfileRepository.FindById(id);
        }

        public IEnumerable<UserProfile> GetAllUserProfiles()
        {
            return _unitOfWork.UserProfileRepository.GetAll();
        }

        public void DeleteUserProfile(UserProfile userProfile)
        {
            _unitOfWork.UserProfileRepository.Delete(userProfile);
            _unitOfWork.Save();
        }

        public void EditUserProfile(UserProfile userProfile)
        {
            _unitOfWork.UserProfileRepository.Edit(userProfile);
            _unitOfWork.Save();
        }

        public IEnumerable<UserProfile> SearchUserProfiles(string userName)
        {
            return _unitOfWork.UserProfileRepository.FindByUsername(userName);
        }
    }
}
