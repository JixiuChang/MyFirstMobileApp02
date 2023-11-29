namespace MyFirstMobileApp.ViewViewModels.SQLLite;

public partial class SQLLiteView : ContentPage
{
	public SQLLiteView()
	{
		InitializeComponent();
		BindingContext = new SQLLiteViewModel();
	}
}