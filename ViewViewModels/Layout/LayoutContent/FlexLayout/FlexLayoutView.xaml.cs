namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.FlexLayout;

public partial class FlexLayoutView : ContentPage
{
	public FlexLayoutView()
	{
		InitializeComponent();
		BindingContext = new FlexLayoutViewModel();
	}
}