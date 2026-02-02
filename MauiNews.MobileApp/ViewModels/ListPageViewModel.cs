using MauiNews.Core.Models;
using MauiNews.Services.Services;
using System.Collections.ObjectModel;

namespace MauiNews.MobileApp.ViewModels
{
    public class ListPageViewModel
    {
        private readonly NewsService _newsService;

        public ListPageViewModel(NewsService newsService)
        {
            _newsService = newsService;
            LoadNews();
        }

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
