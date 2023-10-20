namespace MyFirstMobileApp.ViewViewModels.APPImages;

public partial class APPImageView : ContentPage
{
	public APPImageView()
	{
		InitializeComponent();
		BindingContext = new APPImageViewModel();
	}
}