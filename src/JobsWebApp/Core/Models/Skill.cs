using System.Collections.Generic;

namespace JobsWebApp.Core.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<UserSkill> UserSkills { get; set; }
    }
}
