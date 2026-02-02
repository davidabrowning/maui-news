using Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages;

public partial class DetailPage : ContentPage
{
	private DetailPageViewModel _detailPageViewModel;
	public DetailPage(DetailPageViewModel detailPageViewModel)
	{
		InitializeComponent();
        BindingContext = detailPageViewModel;
		_detailPageViewModel = detailPageViewModel;
	}

	public void SetArticle(Article article)
	{
		_detailPageViewModel.ArticleTitle = article.Title;
        _detailPageViewModel.ArticleContent = article.Content;
		_detailPageViewModel.ArticleUrl = article.Url;
		_detailPageViewModel.ArticleUrlToImage = article.UrlToImage;
		_detailPageViewModel.ArticleSourceName = article.Source.Name;
    }
}