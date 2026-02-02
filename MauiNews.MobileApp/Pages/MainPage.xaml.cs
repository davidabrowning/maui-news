using Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Article article = (Article)e.CurrentSelection.FirstOrDefault();
            DetailPageViewModel detailPageViewModel = new() { Article = article };
            DetailPage detailPage = new(detailPageViewModel);
            await Navigation.PushAsync(detailPage);
        }
    }
}
