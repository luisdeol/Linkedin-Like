using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsWebApp.Controllers
{
    public class JobOffersController : Controller
    {
        private readonly IJobOfferService _jobService;

        public JobOffersController(IJobOfferService jobService)
        {
            _jobService = jobService;
        }
        public IActionResult Index()
        {
            return View(_jobService.GetAllJobOffers());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(JobOffer jobOffer)
        {
            var userProfileId = int.Parse(HttpContext.Session.GetString("sessionUser"));
            jobOffer.UserProfileId = userProfileId;
            jobOffer.CreatedAt = DateTime.Now;
            _jobService.AddJobOffer(jobOffer);
            return RedirectToAction("Index");
        }
    }
}