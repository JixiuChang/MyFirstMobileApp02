using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.AbsoluteLayout;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.VerticalLayout;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.HorizontalLayout;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.FlexLayout;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.StackLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstMobileApp.Models.Titles;

namespace MyFirstMobileApp.ViewViewModels.Layout
{
    internal class LayoutViewModel : BaseViewModel {
        public ICommand StackLayoutButtonClicked { get; set; }
        public ICommand VerticalLayoutButtonClicked { get; set; }
        public ICommand HorizontalLayoutButtonClicked { get; set; }
        public ICommand AbsoluteLayoutButtonClicked { get; set; }
        public ICommand FlexLayoutButtonClicked { get; set; }

        public string StackLayoutButton { get; set; } = TitleLayout.myButtonStack;
        public string VerticalLayoutButton { get; set; } = TitleLayout.myButtonVertical;
        public string HorizontalLayoutButton { get; set; } = TitleLayout.myButtonHorizontal;
        public string AbsoluteLayoutButton { get; set; } = TitleLayout.myButtonAbsolute;
        public string FlexLayoutButton { get; set; } = TitleLayout.myButtonFlex;

        public LayoutViewModel() {
            Title = TitleLayout.myTitle;

            StackLayoutButtonClicked = new Command(StackLayoutClickedAsync);
            VerticalLayoutButtonClicked = new Command(VerticalLayoutClickedAsync);
            HorizontalLayoutButtonClicked = new Command(HorizontalLayoutClickedAsync);
            AbsoluteLayoutButtonClicked = new Command(AbsoluteLayoutClickedAsync);
            FlexLayoutButtonClicked = new Command(FlexLayoutClickedAsync);
        }

        private async void StackLayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }

        private async void VerticalLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VerticalLayoutView());
        }

        private async void HorizontalLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new HorizontalLayoutView());
        }
        private async void AbsoluteLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
        }
        private async void FlexLayoutClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlexLayoutView());
        }
    }
}
