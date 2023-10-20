namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.ActivityIndicator;

public partial class ActivityIndicatorView : ContentPage
{
	public ActivityIndicatorView()
	{
		InitializeComponent();
		BindingContext = new ActivityIndicatorViewModel();
	}
}