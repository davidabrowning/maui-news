using Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private DetailPageViewModel _detailPageViewModel;

        public MainPage(MainPageViewModel mainPageViewModel, DetailPageViewModel detailPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
            _detailPageViewModel = detailPageViewModel;
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Article article = (Article)e.CurrentSelection.FirstOrDefault();
            DetailPage detailPage = new(_detailPageViewModel);
            detailPage.SetArticle(article);
            await Navigation.PushAsync(detailPage);
        }
    }
}
