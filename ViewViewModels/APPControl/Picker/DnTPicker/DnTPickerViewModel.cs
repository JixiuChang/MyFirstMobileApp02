using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.ControlsCollection.DatePickerControl.DatePickerVM;
using MyFirstMobileApp.ViewViewModels.ControlsCollection.DatePickerControl.DatePickerXAML;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.DnTPicker;

public class DnTPickerViewModel : BaseViewModel
{
    public ICommand OnDnTPickerXAMLClicked { get; set; }
    public ICommand OnDnTPickerVMClicked { get; set; }


    public DnTPickerViewModel()
    {
        Title = TitleControl.myDnTPickerTitle;

        OnDnTPickerXAMLClicked = new Command(OnXAMLClickedAsync);
        OnDnTPickerVMClicked = new Command(OnVMClickedAsync);
    }

    private async void OnXAMLClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXAMLView());
    }
    private async void OnVMClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
    }
}