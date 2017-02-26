using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public IEnumerable<Appliance> Appliances { get; set; }
    }
}
