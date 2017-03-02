using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWebApp.Core.Models;
using JobsWebApp.Core.ViewModels;
using JobsWebApp.Data;
using JobsWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsWebApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var sessionId = HttpContext.Session.GetString("sessionUser");
            if (sessionId == null)
                return View();

            var viewModel = new HomeViewModel
            {
                IsAuthenticated = true,
                Posts = _postService.ListAllPosts()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(HomeViewModel vm)
        {
            var post = new Post
            {
                Content = vm.PostFormViewModel.Content,
                CreatedAt = DateTime.Now,
                UserProfileId = int.Parse(HttpContext.Session.GetString("sessionUser"))
            };
            _postService.AddPost(post);
            return RedirectToAction("Index");
        }
    }
}