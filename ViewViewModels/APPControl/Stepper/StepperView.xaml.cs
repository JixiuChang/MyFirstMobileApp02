namespace MyFirstMobileApp.ViewViewModels.APPControl.Stepper;

public partial class StepperView : ContentPage
{
	public StepperView()
	{
		InitializeComponent();
		BindingContext = new StepperViewModel();
	}

	public void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
	{
		double value = e.NewValue;
		RotatingImage.Rotation = value;
		int R = (int)(value / 360 * 255);
        int G = (int)(value / 360 * 184);
        int B = (int)(value / 360 * 200);
        DisplayLabel.TextColor = Color.FromRgb(R, G, B);
		DisplayLabel.Text = string.Format("The Stepper value is {0}", value);
	}
}