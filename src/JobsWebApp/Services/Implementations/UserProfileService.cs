using JobsWebApp.Core;

namespace JobsWebApp.Services.Implementations
{
    public class UserProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
