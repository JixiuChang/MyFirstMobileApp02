using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerResults;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerVM
{
    public class PickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; set; } = "Images/buttonsubmit.png";

        public List<string> OperatorList { get; set; }
        List<OperatorInfo> _operators;
        string _selectedOperator = string.Empty;

        public ICommand OnSubmitClicked { get; }

        public PickerVMViewModel()
        {
            Title = TitleControl.myPickerVMTitle;

            this.GetOperatorList();

            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        private void GetOperatorList()
        {
            var allOperatorInfo = OperatorInfo.GetSampleOperatorData();

            OperatorList = allOperatorInfo.Select(info => info.OperatorName).ToList();
            _operators = allOperatorInfo;
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

        private async void OnSubmitClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_selectedOperator))
            {
                await Application.Current.MainPage.DisplayAlert(TitleControl.myPickerVMTitle, "A selection must be made!", "OK");
                return;
            }

            var selectedOperatorName = _selectedOperator;

            var selectedOperatorInfo = _operators.FirstOrDefault(info => info.OperatorName == selectedOperatorName);

            if (selectedOperatorInfo != null)
            {
                string name = $"{selectedOperatorInfo.OperatorName}";

                await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(name, selectedOperatorInfo.OperatorImage));
            }
        }
    }
}
