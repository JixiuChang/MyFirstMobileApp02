using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 
namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableAddEdit
{
    public class EditCollectionViewModel : BaseViewModel
    {
        public ICommand UpdateButtonClicked { get; set; }
        private string _operatorName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitleAPPCollections.myUpdateUpdateableTitle;
            UpdateButtonClicked = new Command(PerformSave);
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

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_operatorName.Trim()))
            {
                Application.Current.MainPage.DisplayAlert(TitleAPPCollections.myUpdateUpdateableTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            Arknights thisOperator = new Arknights();
            thisOperator.NameOfOperator = _operatorName;

            MessagingCenter.Send<Arknights>(thisOperator, "UpdateOperator");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
#pragma warning restore CA1416 
