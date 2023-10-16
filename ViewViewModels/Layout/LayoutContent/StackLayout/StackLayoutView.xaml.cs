namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.StackLayout;

public partial class StackLayoutView : ContentPage
{
	public StackLayoutView()
	{
		InitializeComponent();
		BindingContext = new StackLayoutViewModel();
	}
}