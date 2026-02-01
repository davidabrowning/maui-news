using Core.Models;
using MauiNews.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNews.MobileApp.ViewModels
{
    public class MainPageViewModel
    {
        private readonly NewsService _newsService;

        public MainPageViewModel(NewsService newsService)
        {
            _newsService = newsService;
            LoadNews();
        }

        public string Title { get; } = "Maui News";
        public ObservableCollection<Article> Articles { get; } = new();

        private async void LoadNews()
        {
            List<Article> newArticles = await _newsService.GetArticlesAsync();
            Articles.Clear();
            foreach (Article newArticle in newArticles)
            {
                Articles.Add(newArticle);
            }
        }
    }
}
