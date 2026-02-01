using Core.Models;
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
        public string Title { get; } = "Maui News";
        public ObservableCollection<Article> Articles { get; } = new() {
            new Article() {Title = "NYT Headline 1"},
            new Article() {Title = "WSJ Headline 2"},
            new Article() {Title = "Reuters Headline 3"},
        };
    }
}
