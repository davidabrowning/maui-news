using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiNews.MobileApp.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        public string articleTitle = string.Empty;
        public string ArticleTitle
        {
            get { return articleTitle; }
            set {
                articleTitle = value;
                OnPropertyChanged(nameof(ArticleTitle));
            }
        }

        public string articleContent = string.Empty;
        public string ArticleContent
        {
            get { return articleTitle; }
            set
            {
                articleTitle = value;
                OnPropertyChanged(nameof(ArticleContent));
            }
        }

        public string articleUrlToImage = string.Empty;
        public string ArticleUrlToImage
        {
            get { return articleTitle; }
            set
            {
                articleTitle = value;
                OnPropertyChanged(nameof(ArticleUrlToImage));
            }
        }

        public string articleSourceName = string.Empty;
        public string ArticleSourceName
        {
            get { return articleTitle; }
            set
            {
                articleTitle = value;
                OnPropertyChanged(nameof(ArticleSourceName));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
