using MauiNews.MobileApp.Services;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages;

public partial class FilterPage : ContentPage
{
	private readonly NewsService _newsService;
	public FilterPage(NewsService newsService)
	{
		InitializeComponent();
		_newsService = newsService;
	}

	private async void FilterButton_Clicked(object sender, EventArgs e)
	{
		MainPage mainPage = new MainPage(new MainPageViewModel(_newsService), new DetailPageViewModel());
        await Navigation.PushAsync(mainPage);
    }
}