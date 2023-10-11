namespace MyFirstMobileApp.ViewViewModels.AbsoluteLayout;

public partial class AbsoluteLayoutView : ContentPage
{
	public AbsoluteLayoutView()
	{
		InitializeComponent();
		BindingContext = new AbsoluteLayoutViewModel();
	}
}