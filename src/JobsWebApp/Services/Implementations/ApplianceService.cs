using JobsWebApp.Core;

namespace JobsWebApp.Services.Implementations
{
    public class ApplianceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplianceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
