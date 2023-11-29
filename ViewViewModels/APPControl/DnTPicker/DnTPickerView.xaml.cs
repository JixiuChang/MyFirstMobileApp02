namespace MyFirstMobileApp.ViewViewModels.APPControl.DnTPicker;

public partial class DnTPickerView : ContentPage
{
	public DnTPickerView()
	{
		InitializeComponent();
		BindingContext = new DnTPickerViewModel();
	}
}