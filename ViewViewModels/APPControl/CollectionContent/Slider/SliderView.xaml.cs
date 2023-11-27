namespace MyFirstMobileApp.ViewViewModels.APPControl.CollectionContent.Slider;

public partial class SliderView : ContentPage
{
	public SliderView()
	{
		InitializeComponent();
		BindingContext = new SliderViewModel();
		this.SetPadding();
	}

	private void SetPadding() {
		if(DeviceInfo.Platform == DevicePlatform.iOS)
		{
			Padding = new Thickness(25);
		}
		else if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			Padding = new Thickness(25);
		}
	}
}