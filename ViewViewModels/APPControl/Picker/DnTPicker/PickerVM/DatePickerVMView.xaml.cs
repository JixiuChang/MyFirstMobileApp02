namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.DnTPicker.PickerVM;

public partial class DatePickerVMView : ContentPage
{
	public DatePickerVMView()
	{
		InitializeComponent();
		BindingContext = new DatePickerVMViewModel();
	}
}