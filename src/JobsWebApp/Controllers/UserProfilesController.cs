using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;
using JobsWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace JobsWebApp.Controllers
{
    public class UserProfilesController : Controller
    {
        private readonly IUserProfileService _userProfileService;
        private readonly IPostService _postService;

        public UserProfilesController(IUserProfileService userProfileService, IPostService postService)
        {
            _postService = postService;
            _userProfileService = userProfileService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var userProfileId = int.Parse(HttpContext.Session.GetString("sessionUser"));
            var userProfile = _userProfileService.GetUserProfile(userProfileId);
            userProfile.Posts = (ICollection<Post>)_postService.GetAllPosts(userProfileId);
            return View(userProfile);
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            var userProfile = _userProfileService.SearchUserProfiles(searchQuery);
            return View(userProfile);
        }

        public IActionResult Search(int id)
        {
            var userProfile = _userProfileService.GetUserProfile(id);
            userProfile.Posts = (ICollection<Post>) _postService.GetAllPosts(id);
            return View("Index", userProfile);
        }
    }
}
