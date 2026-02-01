using Core.Models;
using MauiNews.MobileApp.ViewModels;

namespace MauiNews.MobileApp.Pages;

public partial class DetailPage : ContentPage
{
	public Article Article { get; set; }
	private DetailPageViewModel _detailPageViewModel;
	public DetailPage(DetailPageViewModel detailPageViewModel)
	{
		InitializeComponent();
        BindingContext = detailPageViewModel;
		_detailPageViewModel = detailPageViewModel;
	}

	public void SetArticle(Article article)
	{
		Article = article;
		_detailPageViewModel.ArticleTitle = Article.Title;
        _detailPageViewModel.ArticleContent = Article.Content;
		_detailPageViewModel.ArticleUrlToImage = Article.UrlToImage;
    }
}