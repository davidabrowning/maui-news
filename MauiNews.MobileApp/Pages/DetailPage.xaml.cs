using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel detailPageViewModel)
	{
		InitializeComponent();
        BindingContext = detailPageViewModel;
	}
}