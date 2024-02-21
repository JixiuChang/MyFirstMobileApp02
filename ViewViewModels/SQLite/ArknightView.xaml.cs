namespace MyFirstMobileApp.ViewViewModels.Vacations;

public partial class VacationView : ContentPage
{
	public VacationView()
	{
		InitializeComponent();
		BindingContext = new ArknightViewModel();
	}
}