namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker;

public partial class ListPickerView : ContentPage
{
	public ListPickerView()
	{
		InitializeComponent();
		BindingContext = new ListPickerViewModel();
	}
}