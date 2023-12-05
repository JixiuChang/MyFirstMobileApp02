namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry;

public partial class EntryResultView : ContentPage
{
	public EntryResultView()
	{
		InitializeComponent();
		BindingContext = new EntryResultViewModel();
	}
}