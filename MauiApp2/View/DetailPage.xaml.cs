using MauiApp2.ViewModel;

namespace MauiApp2.View;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}