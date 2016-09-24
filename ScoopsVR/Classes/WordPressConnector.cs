using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ScoopsVRWeb.Classes
{
    public class WordPressConnector
    {

        public List<Post> GetWordPressPosts()
        {
            using (WebClient webClient = new WebClient())
            {
                string blogUrl = @"https://public-api.wordpress.com/rest/v1.1/sites/scoopsdevblog.wordpress.com/posts/";
                string response = webClient.DownloadString(blogUrl);

                WordPressBlog blogPosts = JsonConvert.DeserializeObject<WordPressBlog>(response);

                List<Post> posts = blogPosts.posts.OrderByDescending(x => x.date).Take(3).Select(x => x).ToList();

                return posts;
            }
        }
    }
}