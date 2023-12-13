namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry;

public partial class EntryResultView : ContentPage
{
	public EntryResultView(string entryText)
	{
		InitializeComponent();
		BindingContext = new EntryResultViewModel(entryText);
	}
}