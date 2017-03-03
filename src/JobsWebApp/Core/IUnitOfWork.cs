using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Repositories;

namespace JobsWebApp.Core
{
    public interface IUnitOfWork
    {
        IApplianceRepository ApplianceRepository { get; set; }
        IJobOfferRepository JobOfferRepository { get; set; }
        IPostRepository PostRepository { get; set; }
        IUserProfileRepository UserProfileRepository { get; set; }
        IUserSkillRepository UserSkillRepository { get; set; }
        void Save();
    }
}
