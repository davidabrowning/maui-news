using MauiNews.Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages
{
    public partial class ListPage : ContentPage
    {

        public ListPage(ListPageViewModel listPageViewModel)
        {
            InitializeComponent();
            BindingContext = listPageViewModel;
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
