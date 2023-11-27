namespace MyFirstMobileApp.ViewViewModels.APPControl;

public partial class APPControlView : ContentPage
{
	public APPControlView()
	{
		InitializeComponent();
		BindingContext = new APPControlViewModel();
	}
}