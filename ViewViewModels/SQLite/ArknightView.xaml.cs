namespace MyFirstMobileApp.ViewViewModels.SQLite;

public partial class ArknightView : ContentPage
{
	public ArknightView()
	{
		InitializeComponent();
		BindingContext = new ArknightViewModel();
	}
}