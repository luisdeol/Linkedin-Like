using System.Collections.Generic;

namespace JobsWebApp.Core.Models
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
