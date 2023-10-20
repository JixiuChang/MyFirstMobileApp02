namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.URIImage;

public partial class URIImageView : ContentPage
{
	public URIImageView()
	{
		InitializeComponent();
		BindingContext = new URIImageViewModel();
	}
}