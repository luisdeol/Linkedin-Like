using System.Collections.Generic;
using JobsWebApp.Core.Models;

namespace JobsWebApp.Services.Interfaces
{
    public interface IUserProfileService
    {
        void AddUserProfile(UserProfile userProfile);
        UserProfile GetUserProfile(int id);
        IEnumerable<UserProfile> GetAllUserProfiles();
        void DeleteUserProfile(UserProfile userProfile);
        void EditUserProfile(UserProfile userProfile);
    }
}
