namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerResults;

public partial class PickerResultsView : ContentPage
{
	public PickerResultsView(string value, ImageSource image)
	{
		InitializeComponent();
		BindingContext = new PickerResultsViewModel(value, image);
	}
}