﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class UserSkill
    {
        public int SkillId { get; set; }
        public int UserProfileId { get; set; }

        public Skill Skill { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
