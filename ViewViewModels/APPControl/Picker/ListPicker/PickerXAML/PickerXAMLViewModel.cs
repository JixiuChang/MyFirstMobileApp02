using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerXAML
{
    public class PickerXAMLViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/buttonsubmit.png";
        public ICommand OnSubmitClicked { get; }

        private string _selectedOperator = string.Empty;

        public PickerXAMLViewModel()
        {
            Title = TitleControl.myPickerXAMLTitle;

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedOperator
        {
            get
            {
                return _selectedOperator;
            }

            set
            {
                if (_selectedOperator != value) 
                {
                    SetProperty(ref _selectedOperator, value);
                }

            }
        }

        private async void OnSubmitClickedAsync(Object obj)
        {

            List<OperatorInfo> chars =OperatorInfo.GetSampleOperatorData();

            var result = chars.FirstOrDefault(x => x.OperatorName.Equals(_selectedOperator));

            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(result.OperatorName, result.OperatorImage));

            if (String.IsNullOrEmpty(_selectedOperator))
            {
                await Application.Current.MainPage.DisplayAlert(TitleControl.myPickerXAMLTitle, "A selection must be made!", "OK");
                return;
            }
        }
    }
}
