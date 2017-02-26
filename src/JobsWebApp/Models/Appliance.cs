using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class Appliance
    {
        public int UserProfileId { get; set; }
        public int JobOfferId { get; set; }

        public JobOffer JobOffer { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
