namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.DnTPicker;

public partial class DnTPickerView : ContentPage
{
	public DnTPickerView()
	{
		InitializeComponent();
		BindingContext = new DnTPickerViewModel();
	}
}