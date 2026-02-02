using Core.Models;
using System.Net.Http.Json;

namespace MauiNews.Services.Services
{
    public class NewsService
    {
        public string SearchTerm { get; set; } = string.Empty;
        private readonly HttpClient _httpClient;
        private string _urlBase = $"https://newsapi.org/v2/everything";
        private readonly string _apiKey = "96f9e2bd33a44349b2880c91352a9f66";

        public NewsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("DavidsMauiNewsApp/1.0");
        }

        public async Task<List<Article>> GetArticlesAsync()
        {
            List<Article> articles = new();
            try
            {
                string url = $"{_urlBase}?q={SearchTerm}&apiKey={_apiKey}";
                var response = await _httpClient.GetAsync(url);
                var news = await response.Content.ReadFromJsonAsync<NewsApiResponse>();
                if (news != null && news.Status == "ok")
                {
                    foreach (var article in news.Articles)
                    {
                        articles.Add(article);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return articles;
        }
    }
}
