namespace MyFirstMobileApp.ViewViewModels.VerticalLayout;

public partial class VerticalLayoutView : ContentPage
{
	public VerticalLayoutView()
	{
		InitializeComponent();
		BindingContext = new VerticalLayoutViewModel();
	}
}