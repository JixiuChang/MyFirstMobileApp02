namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.AbsoluteLayout;

public partial class AbsoluteLayoutView : ContentPage
{
	public AbsoluteLayoutView()
	{
		InitializeComponent();
		BindingContext = new AbsoluteLayoutViewModel();
	}
}