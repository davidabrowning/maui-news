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
        public string articleTitle = "Lorem ipsum default title";
        public string ArticleTitle
        {
            get { return articleTitle; }
            set {
                articleTitle = value;
                OnPropertyChanged(nameof(ArticleTitle));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
