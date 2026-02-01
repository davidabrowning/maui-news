using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNews.MobileApp.Services
{
    public class NewsService
    {
        private readonly HttpClient _httpClient;

        public NewsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Article>> GetArticlesAsync()
        {
            await Task.Delay(100);
            return new List<Article>() {
                new Article() {Title = "NYT Headline 1 from newsservice"},
                new Article() {Title = "WSJ Headline 2 from newsservice"},
                new Article() {Title = "Reuters Headline 3 from newsservice"},
            };
        }
    }
}
