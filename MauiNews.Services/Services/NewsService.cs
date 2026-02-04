using MauiNews.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace MauiNews.Services.Services
{
    public class NewsService
    {
        public string SearchTerm { get; set; } = string.Empty;
        private readonly HttpClient _httpClient;
        private string _urlBase;
        private readonly string _apiKey;

        public NewsService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("DavidsMauiNewsApp/1.0");
            _urlBase = configuration["NewsApi:ApiUrlBase"] ?? throw new Exception("Missing api url in appsettings");
            _apiKey = configuration["NewsApi:ApiKey"] ?? throw new Exception("Missing api key in appsettings");
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
