using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JobsWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobsWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Appliance> Appliances { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // UserProfile
            builder.Entity<UserProfile>()
                .HasKey(u => u.Id);

            // Post
            builder.Entity<Post>()
                .HasKey(p => p.Id);
            builder.Entity<Post>()
                .HasOne(p => p.UserProfile)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserProfileId);

            //JobOffer
            builder.Entity<JobOffer>()
                .HasKey(jo => jo.Id);
            builder.Entity<JobOffer>()
                .HasOne(jo => jo.UserProfile)
                .WithMany(u => u.JobOffers)
                .HasForeignKey(jo => jo.UserProfileId);

            //Appliance
            builder.Entity<Appliance>()
                .HasKey(a => new
                {
                    a.JobOfferId,
                    a.UserProfileId
                });
            builder.Entity<Appliance>()
                .HasOne(a => a.UserProfile)
                .WithMany(u => u.Appliances)
                .HasForeignKey(a => a.UserProfileId);
            builder.Entity<Appliance>()
                .HasOne(a => a.JobOffer)
                .WithMany(jo => jo.Appliances)
                .HasForeignKey(a => a.JobOfferId)
                .OnDelete(DeleteBehavior.Restrict);
            // Skil
            builder.Entity<Skill>()
                .HasKey(s => s.Id);
            // UserSkill
            builder.Entity<UserSkill>()
                .HasKey(us => new
                {
                    us.UserProfileId,
                    us.SkillId
                });
            builder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.SkillId);
            builder.Entity<UserSkill>()
                .HasOne(us => us.UserProfile)
                .WithMany(u => u.Skills)
                .HasForeignKey(us => us.UserProfileId)
                .OnDelete(DeleteBehavior.Restrict);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
