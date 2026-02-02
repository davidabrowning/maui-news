using MauiNews.MobileApp.Services;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages;

public partial class FilterPage : ContentPage
{
	private readonly NewsService _newsService;
	private readonly FilterPageViewModel _filterPageViewModel;
	public FilterPage(NewsService newsService)
	{
		InitializeComponent();
		_newsService = newsService;
		_filterPageViewModel = new();
		BindingContext = _filterPageViewModel;
	}

	private async void FilterButton_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		_newsService.SearchTerm = button.Text;
		MainPage mainPage = new MainPage(new MainPageViewModel(_newsService));
        await Navigation.PushAsync(mainPage);
    }

	private async void RandomizeButton_Clicked(object sender, EventArgs e)
	{
		_filterPageViewModel.RandomizeSearchTerms();
	}
}