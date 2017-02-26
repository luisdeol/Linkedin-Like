using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GithubUrl { get; set; }
        public string PersonalWebpageUrl { get; set; }
        public string Bio { get; set; }

        public string UserId { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<JobOffer> JobOffers { get; set; }
        public IEnumerable<Appliance> Appliances { get; set; }
        public IEnumerable<UserSkill> Skills { get; set; }
    }
}
