namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.EmbeddedImage;

public partial class EmbeddedImageView : ContentPage
{
	public EmbeddedImageView()
	{
		InitializeComponent();
		BindingContext = new EmbeddedImageViewModel();
	}
}