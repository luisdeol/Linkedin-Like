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
                Posts = _postService.GetAllPosts()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(HomeViewModel vm)
        {
            var userProfileId = int.Parse(HttpContext.Session.GetString("sessionUser"));
            var post = new Post(vm.PostFormViewModel.Content, userProfileId);
            _postService.AddPost(post);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var post = _postService.GetPost(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            _postService.EditPost(post);
            return RedirectToAction("Index");
        }
    }
}