using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerVM;
using MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker.PickerXAML;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker
{
    public class ListPickerViewModel : BaseViewModel
    {
        public ICommand OnXAMLClicked { get; set; }
        public ICommand OnVMClicked { get; set; }


        public ListPickerViewModel()
        {
            Title = TitleControl.myPickerTitle;

            OnXAMLClicked = new Command(OnXAMLClickedAsync);
            OnVMClicked = new Command(OnVMClickedAsync);

        }

        private async void OnXAMLClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXAMLView());
        }
        private async void OnVMClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerVMView());
        }
    }
}
