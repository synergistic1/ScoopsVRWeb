using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Services;

namespace ScoopsVRWeb.Classes
{
    public class WordPressConnector
    {
        private WordPressBlog blog;
        public WordPressBlog GetBlog()
        {
            if (blog == null)
            {
                using (WebClient webClient = new WebClient())
                {
                    string blogUrl = @"https://public-api.wordpress.com/rest/v1.1/sites/scoopsdevblog.wordpress.com/posts/";
                    string response = webClient.DownloadString(blogUrl);
                    blog = JsonConvert.DeserializeObject<WordPressBlog>(response);
                }
            }
            return blog;
        }
    }
}
