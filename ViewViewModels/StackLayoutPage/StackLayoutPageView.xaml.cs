namespace MyFirstMobileApp.ViewViewModels.StackLayoutPage;

public partial class StackLayoutPageView : ContentPage
{
	public StackLayoutPageView()
	{
		InitializeComponent();
		BindingContext = new StackLayoutPageViewModel();
	}
}