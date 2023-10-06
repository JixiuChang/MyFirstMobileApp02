namespace MyFirstMobileApp.ViewViewModels.Layout;

public partial class LayoutView : ContentPage
{
	public LayoutView()
	{
		InitializeComponent();
		BindingContext = new LayoutViewModel();
	}
}