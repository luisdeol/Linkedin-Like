using System.Collections.Generic;

namespace JobsWebApp.Core.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GithubUrl { get; set; }
        public string PersonalWebpageUrl { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<JobOffer> JobOffers { get; set; }
        public ICollection<Appliance> Appliances { get; set; }
        public ICollection<UserSkill> Skills { get; set; }
    }
}
