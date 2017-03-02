﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core;
using JobsWebApp.Core.Repositories;
using JobsWebApp.Data.Repositories;

namespace JobsWebApp.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IApplianceRepository ApplianceRepository { get; set; }
        public IJobOfferRepository JobRepository { get; set; }
        public IPostRepository PostRepository { get; set; }
        public IUserProfileRepository UserProfileRepository { get; set; }
        public IUserSkillRepository UserSkillRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ApplianceRepository = new ApplianceRepository(_context);
            JobRepository = new JobOfferRepository(_context);
            PostRepository = new PostRepository(_context);
            UserProfileRepository = new UserProfileRepository(_context);
            UserSkillRepository = new UserSkillRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
