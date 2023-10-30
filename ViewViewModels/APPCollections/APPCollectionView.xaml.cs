namespace MyFirstMobileApp.ViewViewModels.APPCollections;

public partial class APPCollectionView : ContentPage
{
	public APPCollectionView()
	{
		InitializeComponent();
		BindingContext = new APPCollectionViewModel();
	}
}