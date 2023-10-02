using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.StackLayoutPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.StackLayout
{
    internal class StackLayoutViewModel : BaseViewModel {
        public ICommand StackLayoutButtonClicked { get; set; }

        public string TitleLayout { get; set; } = string.Empty;
        public string StackLayoutButton { get; set; } = string.Empty;
        public string HorizontalLayoutButton { get; set; } = string.Empty;
        public string VerticalLayoutButton { get; set; } = string.Empty;
        public string AbsoluteLayoutButton { get; set; } = string.Empty;

        public StackLayoutViewModel() {
            TitleLayout = TitleStackLayout.myTitle;
            StackLayoutButton = TitleStackLayout.myButtonStack;
            HorizontalLayoutButton = TitleStackLayout.myButtonHorizontal;
            VerticalLayoutButton = TitleStackLayout.myButtonVertical;
            AbsoluteLayoutButton = TitleStackLayout.myButtonAbsolute;

            StackLayoutButtonClicked = new Command(StackLayoutClickedAsync);
        }

        private async void StackLayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutPageView());
        }
    }
}
