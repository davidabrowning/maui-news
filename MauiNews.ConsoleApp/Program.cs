using MauiNews.Core.Models;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MauiNews.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("DavidsMauiNewsApp/1.0");
            string apiKey = "96f9e2bd33a44349b2880c91352a9f66";
            string url = $"https://newsapi.org/v2/everything?q=keyword&apiKey={apiKey}";
            var response = await httpClient.GetAsync(url);
            var news = await response.Content.ReadFromJsonAsync<NewsApiResponse>();
            if (news != null && news.Status == "ok")
            {
                foreach (var article in news.Articles)
                {
                    Console.WriteLine($"{article.Title}");
                }
            }
        }
    }
}
