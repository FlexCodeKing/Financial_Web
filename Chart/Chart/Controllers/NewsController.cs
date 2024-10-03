using Chart.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chart.Controllers
{

    public class NewsController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string apiUrl = "https://newsapi.org/v2/everything?domains=wsj.com&apiKey=c4194b3ad6e8468d8893df2d5a64b4b3"; // Đặt URL API của bạn vào đây
            List<Article> articles = new List<Article>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(apiUrl);
                var jsonData = JObject.Parse(response);
                var jsonArticles = jsonData["articles"];

                foreach (var article in jsonArticles)
                {
                    articles.Add(new Article
                    {
                        SourceName = article["source"]["name"].ToString(),
                        Author = article["author"]?.ToString(),
                        Title = article["title"].ToString(),
                        Description = article["description"].ToString(),
                        Url = article["url"].ToString(),
                        ImageUrl = article["urlToImage"]?.ToString(),
                        PublishedAt = article["publishedAt"].ToString(),
                        Content = article["content"]?.ToString()
                    });
                }
            }

            return View(articles);
        }
    }
}
