namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerVM;

public partial class PickerVMView : ContentPage
{
	public PickerVMView()
	{
		InitializeComponent();
        BindingContext = new PickerVMViewModel();
    }
}