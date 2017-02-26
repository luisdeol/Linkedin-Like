using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
