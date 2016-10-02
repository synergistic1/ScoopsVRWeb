using System.Web.Mvc;
using ScoopsVRWeb.Models;
using ScoopsVRWeb.Classes;
using System.Collections.Generic;
using System;

namespace ScoopsVRWeb.Controllers
{
    public class HomeController : Controller
    {
        WordPressConnector wpc;
        List<Post> posts;


        public HomeController()
        {
            wpc = new WordPressConnector();
        }
        public ActionResult Index()
        {
            WordPressBlog blog = wpc.GetBlog();
            posts = blog.GetTop3Posts();
            PostViewModel postViewModel = new PostViewModel();
            foreach (var post in posts)
            {
                post.excerpt = post.excerpt.CharacterLimit(75);
            }
            postViewModel.Posts = posts;

            return View(postViewModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Credits()
        {
            return View();
        }

        public ActionResult Download()
        {
            return View();
        }

        public ActionResult Trello()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult GetPostByID(string id)
        {
            Post post = new Post();
            post.content = "Post Not Found";
            WordPressBlog blog = wpc.GetBlog();
            post = blog.GetPostByID(Int32.Parse(id));
            return Json(post);
        }

    }
}
