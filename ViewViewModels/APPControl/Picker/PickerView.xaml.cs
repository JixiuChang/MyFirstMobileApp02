namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker;

public partial class PickerView : ContentPage
{
	public PickerView()
	{
		InitializeComponent();
		BindingContext = new PickerViewModel();
	}
}