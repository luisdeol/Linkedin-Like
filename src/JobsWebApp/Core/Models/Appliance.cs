﻿namespace JobsWebApp.Core.Models
{
    public class Appliance
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public int JobOfferId { get; set; }

        public JobOffer JobOffer { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
