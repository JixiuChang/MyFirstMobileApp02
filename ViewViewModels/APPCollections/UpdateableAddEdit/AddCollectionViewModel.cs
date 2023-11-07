using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 
namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableAddEdit
{
    public class AddCollectionViewModel : BaseViewModel
    {
        public ICommand AddButtonClicked { get; set; }
        private string _operatorName = string.Empty;

        public AddCollectionViewModel()
        {
            Title = TitleAPPCollections.myAddUpdateableTitle;
            AddButtonClicked = new Command(PerformAdd);
        }

        public string OperatorName
        {
            get { return _operatorName; }

            set
            {
                if (_operatorName != value)
                    SetProperty(ref _operatorName, value);
            }
        }

        private void PerformAdd()
        {
            if (string.IsNullOrEmpty(_operatorName.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(TitleAPPCollections.myAddUpdateableTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            Arknights thisOperator = new Arknights();
            thisOperator.NameOfOperator = _operatorName;

            MessagingCenter.Send<Arknights>(thisOperator, "AddOperator");

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.Navigation.PopAsync();
            }
        }
    }
}
#pragma warning restore CA1416 
