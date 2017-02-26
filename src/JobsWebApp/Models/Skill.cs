using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<UserSkill> UserSkills { get; set; }
    }
}
