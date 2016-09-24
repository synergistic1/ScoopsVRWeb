using System.Web.Mvc;
using ScoopsVRWeb.Models;
using ScoopsVRWeb.Classes;
using System.Collections.Generic;

namespace ScoopsVRWeb.Controllers
{
    public class HomeController : Controller
    {
        WordPressConnector wpc;

        public ActionResult Index()
        {
            wpc = new WordPressConnector();
            List<Post> posts = wpc.GetWordPressPosts();
            PostViewModel postViewModel = new PostViewModel();
            postViewModel.Posts = posts;

            //post.Title = "Getting Start - Demo Release!";
            //post.Body = "Welcome to the Scoops homepage! I'm very excited to say that the official demo is now out! Check out the downloads section for more information. This is a brand new area for me. I've never released any kind of game to the public that wasn't part of a jam and I've never built anything in VR before so I'm very excited! I'll be working to flesh out this site in the coming week and get a preliminary roadmap up to make my goals clear.In the mean time I'd love to hear your feedback! Check out the contact section for various ways to get in touch.";
            //post.PostDate = "9.19.2016";
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

        public ActionResult Test()
        {
            return View();
        }
    }
}