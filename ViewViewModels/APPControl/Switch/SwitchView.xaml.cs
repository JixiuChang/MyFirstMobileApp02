namespace MyFirstMobileApp.ViewViewModels.APPControl.Switch;

public partial class SwitchView : ContentPage
{
	public SwitchView()
	{
		InitializeComponent();
		BindingContext = new SwitchViewModel();
	}

	private void Switch1Toggled(object sender, ToggledEventArgs e)
	{
		if(e.Value == false)
		{
			label1.TextColor = Color.FromArgb("#000000");
		}
		else
		{
			label1.TextColor = Color.FromArgb("#ffb8c8");
		}
	}

	private void Switch2Toggled(object sender, ToggledEventArgs e)
	{
		if(e.Value == false)
		{
			label2.TextColor = Color.FromArgb("000000");
		}
		else
		{
			label2.TextColor = Color.FromArgb("#03fcd3");
		}
	}
}