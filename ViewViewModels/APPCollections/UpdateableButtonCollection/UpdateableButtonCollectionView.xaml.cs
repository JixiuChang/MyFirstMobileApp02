namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableButtonCollection;

public partial class UpdateableButtonCollectionView : ContentPage
{
	public UpdateableButtonCollectionView()
	{
		InitializeComponent();
		BindingContext = new UpdateableButtonCollectionViewModel();
	}
}