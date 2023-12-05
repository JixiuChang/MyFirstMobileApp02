using Android.Provider;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry;

public partial class EntryView : ContentPage
{
	public EntryView()
	{
		InitializeComponent();
		BindingContext = new EntryViewModel();
	}

	private void OnSubmitClick(object sender, EventArgs e)
	{
		string entryText = EntryValue.Text;

		if (string.IsNullOrWhiteSpace(entryText))
		{
			Application.Current.MainPage.DisplayAlert(TitleAPPControl.myEntryViewTitle, "Entry Value is: Null. Please Input Value.", "Ok");
		} else
        {
            Application.Current.MainPage.DisplayAlert(TitleAPPControl.myEntryViewTitle, "Entry Value is: " + entryText, "Ok");
        }
	}
}