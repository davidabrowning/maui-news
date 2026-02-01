using Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private DetailPageViewModel _detailPageViewModel;
        int count = 0;

        public MainPage(MainPageViewModel mainPageViewModel, DetailPageViewModel detailPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
            _detailPageViewModel = detailPageViewModel;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
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
