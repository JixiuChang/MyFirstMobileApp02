using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(Arknights arknight)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		operatorName.Text = arknight.NameOfOperator;
	}
}