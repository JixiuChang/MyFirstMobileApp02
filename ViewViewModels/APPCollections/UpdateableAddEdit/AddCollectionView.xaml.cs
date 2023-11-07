namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableAddEdit;

public partial class AddCollectionView : ContentPage
{
	public AddCollectionView()
	{
		InitializeComponent();
		BindingContext = new AddCollectionViewModel();
	}
}