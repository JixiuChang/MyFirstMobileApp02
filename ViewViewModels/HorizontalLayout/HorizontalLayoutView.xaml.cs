namespace MyFirstMobileApp.ViewViewModels.HorizontalLayout;

public partial class HorizontalLayoutView : ContentPage
{
	public HorizontalLayoutView()
	{
		InitializeComponent();
		BindingContext = new HorizontalLayoutViewModel();
	}
}