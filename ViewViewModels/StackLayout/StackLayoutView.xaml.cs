namespace MyFirstMobileApp.ViewViewModels.StackLayout;

public partial class StackLayoutView : ContentPage
{
	public StackLayoutView()
	{
		InitializeComponent();
		BindingContext = new StackLayoutViewModel();
	}
}