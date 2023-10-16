namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.VerticalLayout;

public partial class VerticalLayoutView : ContentPage
{
	public VerticalLayoutView()
	{
		InitializeComponent();
		BindingContext = new VerticalLayoutViewModel();
	}
}