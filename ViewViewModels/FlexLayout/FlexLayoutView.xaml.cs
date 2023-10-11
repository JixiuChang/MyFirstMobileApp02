namespace MyFirstMobileApp.ViewViewModels.FlexLayout;

public partial class FlexLayoutView : ContentPage
{
	public FlexLayoutView()
	{
		InitializeComponent();
		BindingContext = new FlexLayoutViewModel();
	}
}