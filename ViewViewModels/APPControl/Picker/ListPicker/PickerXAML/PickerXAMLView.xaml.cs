namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerXAML;

public partial class PickerXAMLView : ContentPage
{
	public PickerXAMLView()
	{
		InitializeComponent();
		BindingContext = new PickerXAMLViewModel();
	}
}