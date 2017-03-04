using System;

namespace JobsWebApp.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

        public Post(string content, int userProfileId)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            UserProfileId = userProfileId;
        }
    }
}
