namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.HorizontalLayout;

public partial class HorizontalLayoutView : ContentPage
{
	public HorizontalLayoutView()
	{
		InitializeComponent();
		BindingContext = new HorizontalLayoutViewModel();
	}
}