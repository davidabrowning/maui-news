using Core.Models;

namespace MauiNews.MobileApp.ViewModels
{
    public class DetailPageViewModel
    {
        public required Article Article { get; set; }
        public string ArticleTitle { get { return Article.Title; } }
        public string ArticleContent { get { return Article.Content; } }
        public string ArticleUrl { get { return Article.Url; } }
        public string ArticleUrlToImage { get { return Article.UrlToImage;  } }
        public string ArticleSourceName { get { return Article.Source.Name; } }
    }
}
