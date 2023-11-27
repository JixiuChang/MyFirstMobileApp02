using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPControl.CollectionContent.Slider;
using MyFirstMobileApp.ViewViewModels.APPControl.CollectionContent.Stepper;
using MyFirstMobileApp.ViewViewModels.APPControl.CollectionContent.Switch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl
{
    internal class APPControlViewModel : BaseViewModel
    {
        public ICommand SliderButtonPressed { get; set; }
        public ICommand StepperButtonPressed { get; set; }
        public ICommand SwitchButtonPressed { get; set; }

        public string SliderButton { get; set; } = TitleControl.mySliderTitle;
        public string StepperButton { get; set; } = TitleControl.myStepperTitle;
        public string SwitchButton { get; set; } = TitleControl.mySwitchTitle;
        public string EntryButton { get; set; } = TitleControl.myEntryTitle;
        public string PickerButton { get; set; } = TitleControl.myPickerTitle;
        public string DnTPickerButton { get; set; } = TitleControl.myDnTPickerTitle;

        public APPControlViewModel() {
            Title = TitleControl.myTitle;

            SliderButtonPressed = new Command(SliderClickedAsync);
            StepperButtonPressed = new Command(StepperClickedAsync);
            SwitchButtonPressed = new Command(SwitchClickedAsync);
        }

        public async void SliderClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
        public async void StepperClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        }
        public async void SwitchClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }

    }
}
