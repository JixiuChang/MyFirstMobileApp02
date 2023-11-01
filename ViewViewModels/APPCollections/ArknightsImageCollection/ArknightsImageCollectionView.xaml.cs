namespace MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsImageCollection;

public partial class ArknightsImageCollectionView : ContentPage
{
	public ArknightsImageCollectionView()
	{
		InitializeComponent();
		BindingContext = new ArknightsImageCollectionViewModel();
	}
}