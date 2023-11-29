namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry;

public partial class EntryView : ContentPage
{
	public EntryView()
	{
		InitializeComponent();
		BindingContext = new EntryViewModel();
	}
}