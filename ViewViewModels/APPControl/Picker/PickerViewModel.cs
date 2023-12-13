using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPControl.DnTPicker;
using MyFirstMobileApp.ViewViewModels.APPControl.Picker.ListPicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker
{
    internal class PickerViewModel : BaseViewModel
    {
        public ICommand DnTPickerClicked { get; set; }
        public ICommand ListPickerClicked { get; set; }
        public PickerViewModel() 
        {
            Title = TitleAPPControl.myPickerViewTitle;

            DnTPickerClicked = new Command(DnTClickedAsync);
            ListPickerClicked = new Command(ListClickedAsync);
        }

        public async void DnTClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DnTPickerView());
        }

        public async void ListClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListPickerView());
        }
    }
}
